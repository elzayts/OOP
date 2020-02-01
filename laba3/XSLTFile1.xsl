<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html"/>
  <xsl:template match="/">
    <HTML>
      <BODY>
       <TABLE border="3">
          <TR>
            <th>Title</th>
            <th>Author</th>
            <th>Year</th>
            <th>Episodes</th>
            <th>Rating</th>
            <th>Genres</th>
          </TR>
          <xsl:for-each select="AnimeList/Anime">
            <tr>
              <td>
                <xsl:value-of select="@Title"/>
              </td>
              <td>
                <xsl:value-of select="@Author"/>
              </td>
              <td>
                <xsl:value-of select="@Year"/>
              </td>
              <td>
                <xsl:value-of select="@Episodes"/>
              </td>
              <td>
                <xsl:value-of select="@Rating"/>
              </td>
              <td>
                <xsl:value-of select="@Genres"/>
              </td>
            </tr>
          </xsl:for-each>
        </TABLE>
      </BODY>
    </HTML>
  </xsl:template>
</xsl:stylesheet>
