// Write common lines to files.
document.write("<meta name=\"vs_targetSchema\" content=\"HTML 4.0\" />");
document.write("<link rel=\"stylesheet\" type=\"text/css\" href=\"Software Specific.css\" />");
document.write("<script type=\"text/javascript\" language=\"JavaScript\" src=\"Popup Topics.js\"></script>");
document.write("<script type=\"text/javascript\" language=\"JavaScript\" src=\"popup.js\"></script>");

var CreateHeader = function(text) {
	document.write("<table class=\"title\">");
	document.write("    <tr>");
	document.write("        <td><img src=\"Images/aps-logo-2.png\" alt=\"APS Logo\" class=\"aps-logo\"/></td>");
	document.write("        <td class=\"title-text\">" + text + "</td>");
	document.write("        <td><img src=\"Images/aps-logo-blank.png\" alt=\"\" class=\"aps-logo-blank\"/></td>");
	document.write("    </tr>");
	document.write("</table>");
}