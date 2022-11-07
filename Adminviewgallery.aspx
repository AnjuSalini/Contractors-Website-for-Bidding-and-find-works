<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageHomeAdmin.master" AutoEventWireup="true" CodeFile="Adminviewgallery.aspx.cs" Inherits="Adminviewgallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="container background-white">
                    <div class="row margin-vert-30">
                        <div class="col-md-12">
                            </div>
                        </div>
                     <div class="row">
                        <div class="col-md-140 portfolio-group no-padding">
                            <!-- Portfolio Item -->
                            <div class="col-md-140 portfolio-item margin-bottom-140 filer-code">
                                <div>
                                    <a href="#">
                                        <figure>

                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                                             <table><tr> <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td><asp:DataList ID="DataList1" runat="server" DataKeyField="Id" RepeatColumns="4" RepeatDirection="Horizontal">
                                                <ItemTemplate>
                                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("image") %>' Width="250" Height="150" />
                                                </ItemTemplate>
                                            </asp:DataList></td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td></tr></table>

                                            <%--<img src="assets/img/portfolio/image1.jpg" alt="image1">--%>
                                            <%--<figcaption>
                                                <h3 class="margin-top-20">Velit esse molestie</h3>
                                                <span>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam.</span>
                                            </figcaption>--%>
                                        </figure>
                                    </a>
                                </div>
                            </div>
                            <!-- End Portfolio Item -->
                            <!-- Portfolio Item -->
                           <%-- <div class="col-md-6 portfolio-item margin-bottom-40 video">
                                <div>
                                    <a href="#">
                                        <figure>
                                            <img src="assets/img/portfolio/image2.jpg" alt="image2">
                                            <figcaption>
                                                <h3 class="margin-top-20">Quam nunc putamus</h3>
                                                <span>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam.</span>
                                            </figcaption>
                                        </figure>
                                    </a>
                                </div>
                            </div>--%>
                            <!-- End Portfolio Item -->
                            <!-- Portfolio Item -->
                            <%--<div class="col-md-6 portfolio-item margin-bottom-40 video">
                                <div>
                                    <a href="#">
                                        <figure>
                                            <img src="assets/img/portfolio/image3.jpg" alt="image3">
                                            <figcaption>
                                                <h3 class="margin-top-20">Placerat facer possim</h3>
                                                <span>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam.</span>
                                            </figcaption>
                                        </figure>
                                    </a>
                                </div>
                            </div>--%>
                            <!-- End Portfolio Item -->
                            <!-- Portfolio Item -->
                           <%-- <div class="col-md-6 portfolio-item margin-bottom-40 design">
                                <div>
                                    <a href="#">
                                        <figure>
                                            <img src="assets/img/portfolio/image4.jpg" alt="image4">
                                            <figcaption>
                                                <h3 class="margin-top-20">Nam liber tempor</h3>
                                                <span>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam.</span>
                                            </figcaption>
                                        </figure>
                                    </a>
                                </div>
                            </div>--%>
                            <!-- End Portfolio Item -->
                            <!-- Portfolio Item -->
                           <%-- <div class="col-md-6 portfolio-item margin-bottom-40 audio">
                                <div>
                                    <a href="#">
                                        <figure>
                                            <img src="assets/img/portfolio/image5.jpg" alt="image5">
                                            <figcaption>
                                                <h3 class="margin-top-20">Donec non urna</h3>
                                                <span>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam.</span>
                                            </figcaption>
                                        </figure>
                                    </a>
                                </div>
                            </div>--%>
                            <!-- End Portfolio Item -->
                            <!-- Portfolio Item -->
                           <%-- <div class="col-md-6 portfolio-item margin-bottom-40 design">
                                <div>
                                    <a href="#">
                                        <figure>
                                            <img src="assets/img/portfolio/image6.jpg" alt="image6">
                                            <figcaption>
                                                <h3 class="margin-top-20">Nullam consectetur</h3>
                                                <span>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam.</span>
                                            </figcaption>
                                        </figure>
                                    </a>
                                </div>
                            </div>--%>
                            <!-- End Portfolio Item -->
                            <!-- Portfolio Item -->
                          <%--  <div class="col-md-6 portfolio-item margin-bottom-40 audio">
                                <div>
                                    <a href="#">
                                        <figure>
                                            <img src="assets/img/portfolio/image7.jpg" alt="image7">
                                            <figcaption>
                                                <h3 class="margin-top-20">Velit esse molestie</h3>
                                                <span>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam.</span>
                                            </figcaption>
                                        </figure>
                                    </a>
                                </div>
                            </div>--%>
                            <!-- End Portfolio Item -->
                            <!-- Portfolio Item -->
                           <%-- <div class="col-md-6 portfolio-item margin-bottom-40 video">
                                <div>
                                    <a href="#">
                                        <figure>
                                            <img src="assets/img/portfolio/image8.jpg" alt="image8">
                                            <figcaption>
                                                <h3 class="margin-top-20">Quam nunc putamus</h3>
                                                <span>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam.</span>
                                            </figcaption>
                                        </figure>
                                    </a>
                                </div>
                            </div>--%>
                            <!-- End Portfolio Item -->
                        </div>
                    </div>
                </div>
            </div>
                    
</asp:Content>

