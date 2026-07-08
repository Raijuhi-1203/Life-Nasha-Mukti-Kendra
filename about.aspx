<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="about" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!--Page Title-->
    <section class="page-title" style="background-image: url(images/background/7.jpg)">
        <div class="auto-container">
            <h1>About Us</h1>
            <ul class="page-breadcrumb">
                <li><a href="index.aspx">Home</a></li>
                <li>About Us</li>
            </ul>
        </div>
    </section>
    <!--End Page Title-->

    <!--Welcome Section-->
    <section class="welcome-section">
        <div class="auto-container">
            <div class="row clearfix">
                <!--Content Column-->
                <div class="content-column col-md-8 col-sm-12 col-xs-12">
                    <div class="inner-column">
                        <div class="title">Who we are</div>
                        <h2>Welcome to Life Nasha Mukti Kendra</h2>
                        <div class="bold-text">Welcome to Life Nasha Mukti Kendra, a trusted rehabilitation center dedicated to helping individuals overcome addiction and reclaim their lives.</div>
                        <div class="text">
                            <p>With a compassionate and holistic approach, we provide personalized care and support to those battling substance abuse and addiction-related challenges.</p>
                            <p>Our mission is to empower individuals to break free from the chains of addiction and embrace a life of happiness, health, and purpose. We are committed to creating a supportive environment where every individual is treated with respect, dignity, and care.</p>
                        </div>
                        <a id="servicelink" runat="server" class="theme-btn btn-style-one">View Services</a>
                    </div>
                </div>
                <!--Image Column-->
                <div class="image-column col-md-4 col-sm-12 col-xs-12">
                    <div class="image">
                        <img src="images/resource/image-1.jpg" alt="" />
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--End Welcome Section-->

    <!--Fluid Section One-->
    <section class="fluid-section-one">
        <div class="outer-container clearfix">
            <!--Image Column-->
            <div class="image-column" style="background-image: url(images/resource/image-2.jpg);">
                <figure class="image-box">
                    <img src="images/resource/image-2.jpg" alt="">
                </figure>
            </div>
            <!--Content Column-->
            <div class="content-column">
                <div class="inner-box">
                    <h2>Why Choose Us</h2>
                    <div class="big-text">At Life Nasha Mukti Kendra, we understand that every individual’s journey to recovery is unique.</div>
                    <div class="text">Our center offers a peaceful and nurturing space that encourages healing and growth. We believe that family plays a crucial role in recovery. Our programs involve and support families to foster lasting change. </div>

                    <!--Fact Counter-->
                    <div class="fact-counter">
                        <div class="row clearfix">

                            <!--Column-->
                            <div class="column counter-column col-md-4 col-sm-4 col-xs-12">
                                <div class="inner">
                                    <div class="count-outer count-box">
                                        <span class="count-text" data-speed="3000" data-stop="25">0</span>
                                        <span class="plus-tag">k</span>
                                    </div>
                                    <h4 class="counter-title">Happy Customers</h4>
                                </div>
                            </div>

                            <!--Column-->
                            <div class="column counter-column col-md-4 col-sm-4 col-xs-12">
                                <div class="inner">
                                    <div class="count-outer count-box">
                                        <span class="count-text" data-speed="2000" data-stop="5">0</span>
                                    </div>
                                    <h4 class="counter-title">Years Experience</h4>
                                </div>
                            </div>

                            <!--Column-->
                            <div class="column counter-column col-md-4 col-sm-4 col-xs-12">
                                <div class="inner">
                                    <div class="count-outer count-box">
                                        <span class="count-text" data-speed="3000" data-stop="100">0</span>
                                        <span class="plus-tag percent">%</span>
                                    </div>
                                    <h4 class="counter-title">Satisfaction</h4>
                                </div>
                            </div>

                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>
    <!--End Fluid Section One-->

    

    <!--Comfort Section-->
    <section class="comfort-section">
        <div class="auto-container">
            <div class="row clearfix">
                <!--Content Column-->
                <div class="content-column col-md-12 col-sm-12 col-xs-12">
                    <div class="sec-title">
                        <h2>Place Comfortness</h2>
                    </div>
                    <div class="text">
                        <p>At Life Nasha Mukti Kendra, we are committed to helping individuals break free from the harmful effects of substance abuse and lead a life of health, happiness, and prosperity. Our center offers comprehensive rehabilitation and support to those struggling with addiction, guiding them towards a path of recovery with empathy, understanding, and professionalism.</p>
                        <p>Our team consists of certified counselors, medical professionals, psychologists, and support staff, all dedicated to assisting our clients throughout their recovery journey. We offer a safe, supportive, and confidential environment where individuals can find the strength to overcome addiction and rebuild their lives.</p>
                        <p>At Life Nasha Mukti Kendra, we aim to create a positive and lasting impact on the lives of individuals, their families, and the community. Our mission is to restore hope, health, and dignity to those affected by addiction, helping them reclaim control over their lives and pursue their dreams.</p>
                    </div>
                </div>
                
            </div>
        </div>
    </section>
    <!--End Comfort Section-->

    <!--Call To Action-->
    <section class="call-to-action-section" style="background-image: url(images/background/3.jpg)">
        <div class="auto-container">
            <div class="row clearfix">
                <!--Column-->
                <div class="column col-md-9 col-sm-12 col-xs-12">
                    <div class="title">If you or someone you know is struggling with addiction, reach out to us today and take the first step towards recovery.</div>
                    
                </div>
                <!--Column-->
                <div class="column col-md-3 col-sm-12 col-xs-12">
                    <a id="contactlink" runat="server" class="theme-btn btn-style-one">Contact Us</a>
                </div>
            </div>
        </div>
    </section>
    <!--End Call To Action-->


</asp:Content>
