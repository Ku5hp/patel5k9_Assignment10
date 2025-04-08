<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="patel5k9_Assignment10.aspx.cs" Inherits="patel5k9_Assignment10.patel5k9_Assignment10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virat Kohli - Cricket Legend</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            text-align: center;
        }
        header {
            background-color: blue;
            color: white;
            padding: 10px;
        }
        .container {
            width: 80%;
            margin: 20px auto;
            background: #fff;
            padding: 20px;
            border-radius: 8px;
        }
        table {
            width: 100%;
            border-collapse: collapse;
            margin: 20px 0;
        }
        th, td {
            border: 1px solid #ddd;
            padding: 10px;
        }
        th {
            background-color: #333;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h1>Virat Kohli - Cricket Legend</h1>
        </header>
        <div class="container">
            <asp:Image ID="Image1" runat="server" ImageUrl="Viratkohli.jpg" Width="300" AlternateText="Virat Kohli" />
            <p>Virat Kohli is one of the greatest cricketers of all time. He has led the Indian cricket team to many victories and is known for his aggressive playing style and consistency.</p>

            <h2>Career Highlights</h2>
            <asp:BulletedList ID="HighlightsList" runat="server" BulletStyle="Disc"></asp:BulletedList>

            <h2>Statistics</h2>
            <asp:GridView ID="StatsGrid" runat="server" AutoGenerateColumns="False" ShowHeader="true">
                <Columns>
                    <asp:BoundField HeaderText="Format" DataField="Format" />
                    <asp:BoundField HeaderText="Matches" DataField="Matches" />
                    <asp:BoundField HeaderText="Runs" DataField="Runs" />
                    <asp:BoundField HeaderText="Average" DataField="Average" />
                </Columns>
            </asp:GridView>
            
            <h2>Inspirational Quote</h2>
            <blockquote>
                "Self-belief and hard work will always earn you success." – Virat Kohli
            </blockquote>

            <p>
                Learn more about Virat Kohli on his
                <asp:Button ID="ButtonICC" runat="server" Text="View ICC Profile" OnClick="ButtonICC_Click" />
            </p>
        </div>
    </form>
</body>
</html>
