<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="Game.aspx.cs" Inherits="WebForms.Game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Who wants to be a millionaire?</title>
</head>
<body>
    <h1>Хто хоче стати міліонером?</h1>
    
    <form id="frm_play" runat="server" method="get" >
    <div>
        <asp:Button ID="btn_newGame" Text="Нова гра" runat="server" OnClick="btn_newGame_Click" /><asp:Button ID="btn_exit" Text="Вихід" runat="server" />
        <asp:Label ID="lbl_question" Text="Запитання" runat="server"></asp:Label>
        <asp:Panel ID="pnl_param" runat="server">
            <asp:RadioButtonList ID="rblst_anwer" runat="server" >
                <asp:ListItem Value="a"></asp:ListItem>
                <asp:ListItem Value="b"></asp:ListItem>
                <asp:ListItem Value="c"></asp:ListItem>
                <asp:ListItem Value="d"></asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
        <asp:Button ID="btn_check" Text="Відповісти" OnClick="btn_check_Click" runat="server"/>
        <asp:Label ID="lbl_score" Text="Результат:" runat="server"></asp:Label>   
    </div>
    </form>
</body>
</html>
