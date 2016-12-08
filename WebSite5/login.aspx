<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/StyleSheet2.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
 <div class="imgcontainer">
    <img src="images/img_avatar2.png" class="avatar" />
  </div>
  <table align="Center"> 
      <tr>   
          <td align="center" width="20%">      
  <div class="container">
    <label><b>Username</b></label>
    
      <asp:TextBox ID="uname" placeholder="Enter Username" runat="server" required></asp:TextBox>
  </div>
         <div class="container">
    <label><b>Password</b></label>
    
              <asp:TextBox ID="pwd" placeholder="Enter Username" runat="server" required></asp:TextBox>
   </div>
 <div class="container">
   <asp:Button ID="Button1" Cssclass="button" type="button" runat="server" Text="Login"  OnClick="Button1_Click"  />
    <input type="checkbox" checked="checked"/> Remember 
 </div>
      <div class="container" style="background-color:#f1f1f1">
    <button type="button" class="cancelbtn">Cancel</button>
    <span>Forgot <a href="#">password?</a></span>
  </div>   
     </td>
        </tr>
    </table>
    

 
    </form>
</body>
</html>
