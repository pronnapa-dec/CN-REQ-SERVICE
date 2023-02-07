<%@ Page Language="C#" %>
<%@ Import Namespace="KeepAutomation.Barcode.Web" %>
<%
	BarCodeStream.generateBarcode(Request, Response);
%>
