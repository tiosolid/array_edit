# ArrayEdit - A Tool to parse and generate data for EMV applets

This simple tool can be used to parse, edit and generate data for my [EMV applet project](https://github.com/tiosolid/emv_applet).
The tool is in portuguese but is very simple to use. Just paste the content of an TLV encoded byte array and the tool will parse the tags and the data into a grid. You can then edit the data and regenerate a new array with the edited data.

# Copyright

This project includes the class `ASN1.cs`, responsible for parsing the TLV data into objects. The original copyright is on the top of the cs file. All rights reserved to their creators.