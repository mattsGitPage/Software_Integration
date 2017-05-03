<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <html>
      <body>
        <h1>database</h1>
        <table border="1">
          <tr>
            <td>
              <b>sender</b>
            </td>
            <td>
              <b>reciever</b>
            </td>
            <td>
              <b>timestamp</b>
            </td>
            <td>
              <b>message</b>
            </td>
          </tr>
          <!--select the parent node and then the child node to iterate through the values-->
          <!--this case persons is root with person as child each child has
                multiple attributes that we will need to sort through-->
          <xsl:for-each select="database/user">
            <tr style="font-size: 12pt; font-family: verdana">
              <td>
                <!--access each persons personal info-->
                <xsl:value-of select="senderID/sendName"/>
              </td>
              <td>
                <xsl:value-of select="recieverID/recieveName"/>
              </td>
              <td>
                <xsl:value-of select="timeStamp/time"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>