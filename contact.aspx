<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">



    <!--Page Title-->
    <section class="page-title" style="background-image: url(images/background/7.jpg)">
        <div class="auto-container">
            <h1>Contact Us</h1>
            <ul class="page-breadcrumb">
                <li><a href="index.aspx">Home</a></li>
                <li>Contact Us</li>
            </ul>
        </div>
    </section>
    <!--End Page Title-->


     <!--Appointment Section-->
 <section class="appointment-section" style="background-image: url(images/resource/image-3.jpg)">
     <div class="auto-container">
         <div class="row clearfix">
             <!--Form Column-->
             <div class="form-column col-md-7 col-sm-12 col-xs-12">
                 <div class="inner-column">

                     <!--Default Form-->
                     <div class="default-form">
                         <div>
                             <!--Form Group-->
                             <div class="form-group">
                                 <asp:TextBox id="name" runat="server" type="name" value="" placeholder="Name*" required></asp:TextBox>
                             </div>
                             <!--Form Group-->
                             <div class="form-group">
                                 <asp:TextBox id="email" runat="server" type="email" name="email" value="" placeholder="Email Address*" required></asp:TextBox>
                             </div>
                             <!--Form Group-->
                             <div class="form-group">
                                 <asp:TextBox id="mobile" runat="server" type="text" name="mobile" value="" placeholder="Mobile No.*" required></asp:TextBox>
                             </div>
                             <!--Form Group-->
                             <div class="form-group">
                                 <asp:TextBox id="msg" runat="server" TextMode="MultiLine" name="message" placeholder="Your Message*"></asp:TextBox>
                             </div>
                             <!--Form Group-->
                             <div class="form-group">
                                 <button id="btnsend" runat="server" onserverclick="btnsend_ServerClick" type="submit" class="theme-btn btn-style-one">Send It</button>
                             </div>
                         </div>
                     </div>
                     <!--Default Form-->

                 </div>
             </div>
             <!--Info Column-->
             <div class="info-column col-md-5 col-sm-12 col-xs-12">
                 <div class="inner-box">
                     <div class="title">Get Appointment</div>
                     <h2>You can drop message for any querry.</h2>
                     <h3>Call us on</h3>
                     <div class="number">9598211004</div>
                 </div>
             </div>
         </div>
     </div>
 </section>
 <!--End Appointment Section-->



</asp:Content>
