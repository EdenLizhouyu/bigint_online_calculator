<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="myfirstWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: small;
        }
    </style>
</head>
<body>
    <body style="text-align:center" > 
    <form id="form1" runat="server">
        <div>
            <br />
            &nbsp;<strong>大整数在线计算器</strong><br />
            <br />
            <br />
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="553px"></asp:TextBox>
            &nbsp;&nbsp;
        </div>
        <p>
            <asp:Button ID="Button_add" runat="server" OnClick="Button_add_Click" Text="+" Width="34px" Height="27px" />
&nbsp;
            <asp:Button ID="Button_sub" runat="server" OnClick="Button_sub_Click" Text="-" Width="34px" Height="27px" />
&nbsp;
            <asp:Button ID="Button_multi" runat="server" OnClick="Button_multi_Click" Text="*" Width="34px" Height="27px" />
&nbsp;
            <asp:Button ID="Button_div" runat="server" OnClick="Button_div_Click" Text="/" Width="34px" Height="27px" />
        &nbsp;
            <asp:Button ID="Button_mod" runat="server" Height="27px" OnClick="Button_mod_Click1" style="margin-top: 0px" Text="%" Width="34px" />
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Width="553px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="计算(calculate)" />
        </p>
        <asp:TextBox ID="TextBox_outcome" runat="server" OnTextChanged="TextBox_outcome_TextChanged" Width="553px"></asp:TextBox>
        <br />
        <br />
        <span class="auto-style1">（支持任意两个整数的加减乘除和取模，取模按照c#语言规则运算）<br />
        </span>
        <br />
        <span class="auto-style1">制作|铁道老中医&nbsp;&nbsp;&nbsp; 联系/报错|email：<span style="color: rgb(0, 0, 0); font-family: -apple-system, &quot;Helvetica Neue&quot;, Arial, &quot;PingFang SC&quot;, &quot;Hiragino Sans GB&quot;, STHeiti, &quot;Microsoft YaHei&quot;, &quot;Microsoft JhengHei&quot;, &quot;Source Han Sans SC&quot;, &quot;Noto Sans CJK SC&quot;, &quot;Source Han Sans CN&quot;, &quot;Noto Sans SC&quot;, &quot;Source Han Sans TC&quot;, &quot;Noto Sans CJK TC&quot;, &quot;WenQuanYi Micro Hei&quot;, SimSun, sans-serif; font-size: 20px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">tiedaolaozhongyi@foxmail.com</span></form>
</body>
</html>
