<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>




<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>

	</div>
	<asp:AccessDataSource ID="AccessDataSource1" runat="server" 
		DataFile="~/App_Data/nwind.mdb" 
		SelectCommand="SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]">
	</asp:AccessDataSource>
	<br />
	<br />
	</form>
</body>
</html>