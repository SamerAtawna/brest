<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="bRest._default" %>


<!DOCTYPE html>
<html>
  <head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title></title>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.2/js/bootstrap.min.js" integrity="sha384-vZ2WRJMwsjRMW/8U7i6PWi6AlO1L79snBrmgiDpgIWJ82z8eA5lenwvxbMV1PAh7" crossorigin="anonymous"></script>

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.2/css/bootstrap.min.css" integrity="sha384-y3tfxAZXuh4HwSYylfB+J125MxIs6mR5FOHamPBG064zB+AFeWH94NdvaCBm8qnd" crossorigin="anonymous">
<style>
@import url('https://fonts.googleapis.com/css?family=Assistant');
body {
    background-color: #e5eeff;
    font-family: "Assistant";
    }
    .a{
      border-top-left-radius: 10px;
      border-bottom-left-radius: 10px;
      margin-left:20px;
    }
    .b{
      text-align: center;
      font-size: 28px;

    }
.c{
  text-align: right;
  border-top-right-radius: 10px;
  border-bottom-right-radius: 10px;
width:30%;

}

.a,.b,.c{
  background-color: #093fa5;
  color:white;
    height:80px;
    margin-top: 5px;
    padding-top: 15px;



}
.topnav{

max-width: 100%;
}
.img{
  height:55px;

}
.d{

  padding-top: 15px;



  
}
.e{
  padding-top: 15px;

}
.d,.e{
  margin-top:15px;
  height:800px;
}
.Items{
border-radius: 7px;
  border: 1px solid white;
  background-color: #ffffff;
  height:95%;
    box-shadow: 10px 10px 5px grey;
  padding-left: 5px;
  padding-top: 10px;
      direction: rtl;
  
}
.menu{
border-radius: 7px;
  border: 1px solid white;
  background-color: #ffffff;
  height:95%;
    box-shadow: 10px 10px 5px grey;
  padding-left: 5px;
  padding-top: 10px;
      direction: rtl;
            padding-top: 40px;
      padding-right:50px;
  
}
.button {
    background-color: #4CAF50;
    border: none;
    color: white;
    padding: 15px 32px;
    text-align: center;
    text-decoration: none;
    display: inline-block;
    font-size: 16px;
    margin: 4px 2px;
    cursor: pointer;
}

    .Items {
    border:none;
    padding-right : 5px;
    margin-top: 10px;

    }

</style>

  </head>
  <body>
      <form id="form1" runat="server">
<div class="container-fluid topnav">
<div class="row">
  <div class="col-lg-4 a"><!-- Cashier Details -->
      IP:
      <asp:Label ID="ip" runat="server"></asp:Label>
      <br>
  מס קופה : 23
    </div>
    <div class="col-lg-4 b"><!-- Menu -->
      משאית מזון
      </div>
      <div class="col-lg-4 c"><!-- time -->
          <img src="pics/intelpng.png" class="img">
        </div>
</div>
</div>
<div class="container"><!-- Order Screen-->
  <div class="row">
    <div class="col-lg-3 d"><!-- Order Items -->
       <div class="menu">
           <table>
            <tr><td><asp:ListBox ID="listprize" runat="server" Height="667px"></asp:ListBox></td>
    

              <td>   <asp:ListBox ID="itemlist" runat="server"  Height="667px" Width="242px" CssClass="itm"></asp:ListBox></td>
                </tr>
            </table>
   

  </div>
     
       
    
    </div>

    <div class="col-lg-9 e"><!-- MENU -->
      <div class="menu"><asp:Panel ID="panelButtons" runat="server">
    </asp:Panel></div>
          </div>
    
  </div>
  </div>


          <asp:HiddenField ID="hf1" runat="server" />

      </form>

  </body>
</html>
