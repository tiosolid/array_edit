using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Mono.Security;
using System.Xml.Linq;
using System.Reflection;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            StringBuilder arrayEntrada = new StringBuilder();
            Regex parser = new Regex(@"0x([A-Fa-f0-9][A-Fa-f0-9])");
            ASN1 tlvData;

            //Limpar o datagrid
            dgvDados.Rows.Clear();

            //Limpar o array (remover tags, bytes e representações 0x)
            foreach (Match singleMatch in parser.Matches(txtArrayEntrada.Text))
            {
                arrayEntrada.Append(singleMatch.Groups[1]);
            }

            if ((arrayEntrada.Length % 2) != 0) {
                MessageBox.Show("Número ímpar de bytes detectado", "Erro ao Converter o Array", MessageBoxButtons.OK);
                return;
            }

            //Converter a string de dados para byte[]
            byte[] hexArray = stringToByteArray(arrayEntrada.ToString());

            //Criar objeto ASN1 com base nos dados
            try
            {
                tlvData = new ASN1(hexArray);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Certifique-se que todos os campos foram copiados e que a string é um dado TLV válido", "Erro ao decodificar dados TLV", MessageBoxButtons.OK);
                return;
            }

            //Guardar o tipo de array importado (77, 70, 80), primeiro byte dos dados indica o array
            StringBuilder mainTag = new StringBuilder();
            StringBuilder tMainDados = new StringBuilder();
            foreach (byte b in tlvData.Tag) { mainTag.AppendFormat("{0:X2}", b); }
            foreach (byte b in tlvData.Value) { tMainDados.AppendFormat("{0:X2}", b); }
            txtMainTag.Text = mainTag.ToString();
            txtMainDados.Text = tMainDados.ToString();

            //percorrer com for o objeto ASN1 e criar os row e popular datagrid
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ArrayEdit.TagList.xml");
            XDocument tagList = XDocument.Load(stream);

            foreach (ASN1 a in tlvData) { addDataRows(a, tagList); }

            btnGerarSaida.Enabled = true;
        }

        private void btnGerarSaida_Click(object sender, EventArgs e)
        {
            txtArraySaida.Clear();
            //Varrer datagrid lendo os rows e montar uma string com os dados (stringbuilder se possivel)
            StringBuilder arraySaida = new StringBuilder();

            //Para cada row, calcular o lenght e com base nele calcular se o dado precisa de padding (com F no final)
            foreach (DataGridViewRow row in dgvDados.Rows)
            {
                String dados = (String)row.Cells["dados"].Value;
                String tag = (String)row.Cells["tag"].Value;

                if ((dados.Length % 2) != 0) { dados = dados + "F"; }
                int length = dados.Length / 2;

                arraySaida.Append(tag);
                if (length > 127) { arraySaida.Append("81"); /* 2 byte length */ }
                arraySaida.Append(length.ToString("X2")); //int to hex
                arraySaida.Append(dados);
            }

            //Ccalcular o length total de todo o TLV e adicionar a tag do tipo de array importado (salvo no passo de analisar)
            int total_length = arraySaida.Length / 2;
            arraySaida.Insert(0, total_length.ToString("X2"));
            if (total_length > 127) { arraySaida.Insert(0, "81"); /* 2 byte length */ }
            arraySaida.Insert(0, txtMainTag.Text);

            //Montar o array "especial"
            for (int pos = 0; pos < arraySaida.Length; pos = pos + 2)
            {
                txtArraySaida.AppendText("(byte) 0x" + arraySaida[pos] + arraySaida[pos + 1] + ", ");
            }
        }

        public byte[] stringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private void addDataRows(ASN1 tlvData, XDocument tags)
        {
            StringBuilder tag = new StringBuilder();
            StringBuilder value = new StringBuilder();
            String description;
            XElement descriptionTag;
            foreach (byte b in tlvData.Tag) { tag.AppendFormat("{0:X2}", b); }
            foreach (byte b in tlvData.Value) { value.AppendFormat("{0:X2}", b); }

            descriptionTag = tags.Descendants().Where(el => el.Attributes().Any(a => a.Name == "Tag" && a.Value == tag.ToString())).FirstOrDefault();
            if (descriptionTag != null)
            {
                description = descriptionTag.Attribute("Description").Value;
            }
            else
            {
                description = "Tag Desconhecida";
            }

            dgvDados.Rows.Add(tag.ToString(), description, value.ToString());

           if (tlvData.Count > 0)
            {
                foreach (ASN1 a in tlvData) { addDataRows(a, tags); }
            }
        }

        private void btnAsciiHex_Click(object sender, EventArgs e)
        {
            txtHex.Clear();
            //Converter o texto para HEX (nao esquecer do padding) e por no mesmo campo do texto fonte
            foreach (Char c in txtAscii.Text) { txtHex.AppendText(Convert.ToByte(c).ToString("X2")); }
        }

        private void txtArrayEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtArrayEntrada.SelectAll();
            }
        }

        private void txtArraySaida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtArraySaida.SelectAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (TxtLENGTH.Text == "7F")
            {
                string hexa81 = TxtTAG.Text + 81 + TxtLENGTH.Text + TxtHexEntrada.Text;
                string resultado81 = Regex.Replace(hexa81, ".{2}", "(byte) 0x$0, ");

                TxtHexaSaida.Text = resultado81;
                TxtHexaSaida.SelectAll();
                TxtHexaSaida.Focus();
            }

            else

            {
                string hexa = TxtTAG.Text + TxtLENGTH.Text + TxtHexEntrada.Text;

                string resultado = Regex.Replace(hexa, ".{2}", "(byte) 0x$0, ");

                TxtHexaSaida.Text = resultado;
                TxtHexaSaida.SelectAll();
                TxtHexaSaida.Focus();

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtHexaSaida.Clear();
            TxtHexEntrada.Clear();
            TxtTAG.Clear();
            TxtLENGTH.Clear();
        }
    }
}
