document.write("<object width=\"0\" height=\"0\" id=\"hhpopuplink\" type=\"application/x-oleobject\" classid=\"clsid:adb880a6-d8ff-11cf-9377-00aa003b7a11\"></object>");
function popup(id)
{
	hhpopuplink.TextPopup(id, FontFace, -1, -1, -1, -1);
}