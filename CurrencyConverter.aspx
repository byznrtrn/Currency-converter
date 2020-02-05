<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CurrencyConverter.aspx.cs" Inherits="CurrencyConverter" %>

<!DOCTYPE html>
<html>
    <head>
        <title> Currency Converter</title>
           <style>
         p {
    text-align:center;
    
}
     
           
            #Currency {
                width: 111px;
            }
     
                   </style>
            </head>
   
    <body style="left: 0px; top: 0px"> 
                      
        <form ID="form1" runat="server" method="post"> 
               
            <br />
            <br />

                 
            <div class ="main">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                Convert:&nbsp
                <input type="text" ID="US" runat="server" /> &nbsp Turkish Liras to  &nbsp;
                <select ID="Currency" runat="server"/>
                <br /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input type="submit" value="Convert" ID="Convert" OnServerClick="Convert_ServerClick" runat="server" />
              
<br/> 
                <p style = "font-weight: bold" ID = "Result" runat = "server" > </p>
                <br/><br/>
               
            </div>
        </form>
       
    </body>
    
</html>
