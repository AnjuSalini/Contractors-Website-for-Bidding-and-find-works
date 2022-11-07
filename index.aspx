<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Architectural Company</title>
        <!-- Meta -->
        <meta http-equiv="content-type" content="text/html; charset=utf-8" />
        <meta name="description" content=""/>
        <meta name="author" content=""/>
        <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
        <!-- Favicon -->
        <link href="favicon.ico" rel="shortcut icon"/>
        <!-- Bootstrap Core CSS -->
        <link href="assets/css/bootstrap.css" rel="stylesheet"/>
        <!-- Template CSS -->
        <link  href="assets/css/animate.css" rel="stylesheet"/>
        <link  href="assets/css/font-awesome.css" rel="stylesheet"/>
        <link  href="assets/css/nexus.css" rel="stylesheet"/>
        <link  href="assets/css/responsive.css" rel="stylesheet"/>
        <link href="assets/css/custom.css" rel="stylesheet"/>
        <!-- Google Fonts-->
        <link href="http://fonts.googleapis.com/css?family=Roboto+Condensed:400,300" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
     <div id="body-bg">
            <!-- Phone/Email -->
            <div id="pre-header" class="background-gray-lighter">
                <div class="container no-padding">
                    <div class="row hidden-xs">
                        <div class="col-sm-6 padding-vert-5">
                            <strong>Phone:</strong>&nbsp;1-800-123-4567
                        </div>
                        <div class="col-sm-6 text-right padding-vert-5">
                            <strong>Email:</strong>&nbsp;info@construction.com
                        </div>
                    </div>
                </div>
            </div>
            <!-- End Phone/Email -->
            <!-- Header -->
            <div id="header">
                <div class="container">
                    <div class="row">
                        <!-- Logo -->
                        <div class="logo">
                            <a href="index.html" title="">
                                <img src="images/logo.jpg" alt="Logo" />
                            </a>
                        </div>
                        <!-- End Logo -->
                    </div>
                </div>
            </div>
            <!-- End Header -->
            <!-- Top Menu -->
            <div id="hornav" class="bottom-border-shadow">
                <div class="container no-padding border-bottom">
                    <div class="row">
                        <div class="col-md-8 no-padding">
                            <div class="visible-lg">
                                <ul id="hornavmenu" class="nav navbar-nav">
                                    <li>
                                        <a href="index.aspx" class="fa-home active">Home</a>
                                    </li>
                                    <li><span class="fa-copy ">Registration</span>
                                            <ul>
                                                <li class="parent"><span><a href="Ownerregistration.aspx">Owner Registration</a></span>
                                                  
                                                </li>
                                                <li class="parent"><span><a href="Contractorregistration.aspx">Contractor Registration</a></span>
                                                   </li>
                                            </ul>
                                        </li>
                                        <li><span class="fa-copy ">Pages</span>
                                            <ul>
                                                <li><a href="#aboutus">About Us</a> </li>
                                                <li><a href="#services">Services</a> </li>
                                              
                                            </ul>
                                        </li>
                                        <li><span class="fa-th ">Gallery</span>
                                            <ul>
                                                <li><a href="Gallery.aspx">View Gallery</a> </li>
                                               
                                            </ul>
                                        </li>
                                        <li><span class="fa-font ">Login Here</span>
                                            <ul>
                                                <li><a href="login.aspx">Login</a> </li>
                                              <%--  <li><a href="blog-single.html">Contractor Registration</a> </li>--%>
                                            </ul>
                                        </li>
                                        <li><a href="#contact" class="fa-comment ">Contact</a> </li>
                                    </ul>
                            </div>
                        </div>
                        <div class="col-md-4 no-padding">
                            <ul class="social-icons pull-right">
                                <li class="social-rss">
                                    <a href="#" target="_blank" title="RSS"></a>
                                </li>
                                <li class="social-twitter">
                                    <a href="#" target="_blank" title="Twitter"></a>
                                </li>
                                <li class="social-facebook">
                                    <a href="#" target="_blank" title="Facebook"></a>
                                </li>
                                <li class="social-googleplus">
                                    <a href="#" target="_blank" title="Google+"></a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <!-- End Top Menu -->
            <!-- === END HEADER === -->
            <!-- === BEGIN CONTENT === -->
            <div id="slideshow" class="bottom-border-shadow">
                <div class="container no-padding background-white bottom-border">
                    <div class="row">
                        <!-- Carousel Slideshow -->
                        <div id="carousel-example" class="carousel slide" data-ride="carousel">
                            <!-- Carousel Indicators -->
                            <ol class="carousel-indicators">
                                <li data-target="#carousel-example" data-slide-to="0" class="active"></li>
                                <li data-target="#carousel-example" data-slide-to="1"></li>
                                <li data-target="#carousel-example" data-slide-to="2"></li>
                            </ol>
                            <div class="clearfix"></div>
                            <!-- End Carousel Indicators -->
                            <!-- Carousel Images -->
                            <div class="carousel-inner">
                                <div class="item active">
                                    
                                    <img src="assets/img/slideshow/Untitled-2%20copy.png" />
                                </div>
                                <div class="item">
                                    <img src="assets/img/slideshow/Untitled-3%20copy.png" />
                                </div>
                                <div class="item">
                                    <img src="assets/img/slideshow/Untitled-1%20copy.png" />
                                </div>
                                <div class="item">
                                    <img src="assets/img/slideshow/Untitled-2copy.png" />
                                </div>
                            </div>
                            <!-- End Carousel Images -->
                            <!-- Carousel Controls -->
                            <a class="left carousel-control" href="#carousel-example" data-slide="prev">
                                <span class="glyphicon glyphicon-chevron-left"></span>
                            </a>
                            <a class="right carousel-control" href="#carousel-example" data-slide="next">
                                <span class="glyphicon glyphicon-chevron-right"></span>
                            </a>
                            <!-- End Carousel Controls -->
                        </div>
                        <!-- End Carousel Slideshow -->
                    </div>
                </div>
            </div>
            <div id="icons" class="bottom-border-shadow">
                <div class="container background-grey bottom-border">
                    <div class="row padding-vert-60">
                        <!-- Icons -->
                        <div class="col-md-4 text-center">
                            <i class="fa-cogs fa-4x color-primary animate fadeIn"></i>
                            <h2 class="padding-top-10 animate fadeIn">Experience our Project Gallery</h2>
                            <p class="animate fadeIn">We love to build. What can we build for you?</p>
                        </div>
                        <div class="col-md-4 text-center">
                            <i class="fa-cloud-download fa-4x color-primary animate fadeIn"></i>
                            <h2 class="padding-top-10 animate fadeIn">We are more than builders.</h2>
                            <p class="animate fadeIn">We are construction partners who are passionate about what we do and our partners’ success. We pride ourselves on being solution providers.</p>
                        </div>
                        <div class="col-md-4 text-center">
                            <i class="fa-bar-chart fa-4x color-primary animate fadeIn"></i>
                            <h2 class="padding-top-10 animate fadeIn">Sharing Our Vision. Building Success</h2>
                            <p class="animate fadeIn">Our Companies are construction leaders in buildings,civil infrastructure and heavy industrial markets</p>
                        </div>
                        <!-- End Icons -->
                    </div>
                </div>
            </div>
         
            <div id="content" class="bottom-border-shadow" >
                <div class="container background-white bottom-border" id="aboutus">
                    <div class="row margin-vert-30">
                        <!-- Main Text -->
                        <div class="col-md-6" >
                            <h2>About Us</h2>
                            <p>Our Company started since 1995.Construction is the process of constructing a building or infrastructure. Construction differs from manufacturing in that manufacturing typically involves mass production of similar items without a designated purchaser, while construction typically takes place on location for a known client. Construction as an industry comprises six to nine percent of the gross domestic product of developed countries.Construction starts with planning,[citation needed] design, and financing; and continues until the project is built and ready for use..
</p>
                            <p>PC Construction partners with clients from the very beginning to listen to their needs and develop a clear and shared vision for a project. Then we collaborate with talented architects, engineers, and subcontractors to bring that vision to life. </p>
                        </div>
                        <!-- End Main Text -->
                        <div class="col-md-6"  id="services">
                            <h2 class="padding-vert-10">Services</h2>
                        </div>
                        Our Construction Company is large enough to offer the range of services needed, but small enough to deliver projects with personal attention to our clients’ quality standards, schedules, and budgets. Our skilled teams take pride in guiding a project from conception to successful completion.
                    </div>
                </div>
            </div>
             
            <!-- Portfolio -->
            <div id="portfolio" class="bottom-border-shadow">
                <div class="container bottom-border">
                    <div class="row padding-top-40">
                        <ul class="portfolio-group">
                            <!-- Portfolio Item -->
                            <li class="portfolio-item col-sm-4 col-xs-6 margin-bottom-40">
                                <a href="#">
                                    <figure class="animate fadeInLeft">
                                        <img alt="image1" src="imagecarousal/1%20(3).jpg" />
                                        <%--<figcaption>
                                            <h3>Velit esse molestie</h3>
                                            <span>Vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui et everti tamquam suavitate mea.</span>
                                        </figcaption>--%>
                                    </figure>
                                </a>
                            </li>
                            <!-- //Portfolio Item// -->
                            <!-- Portfolio Item -->
                            <li class="portfolio-item col-sm-4 col-xs-6 margin-bottom-40">
                                <a href="#">
                                    <figure class="animate fadeIn">
                                        <img alt="image2" src="imagecarousal/1.jpg" /> 
                                        <%--<figcaption>
                                            <h3>Quam nunc putamus</h3>
                                            <span>Vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui et everti tamquam suavitate mea.</span>
                                        </figcaption>--%>
                                    </figure>
                                </a>
                            </li>
                            <!-- //Portfolio Item// -->
                            <!-- Portfolio Item -->
                            <li class="portfolio-item col-sm-4 col-xs-6 margin-bottom-40">
                                <a href="#">
                                    <figure class="animate fadeInRight">
                                        <img alt="image3" src="imagecarousal/Construction-engineer.jpg" />
                                        <%--<figcaption>
                                            <h3>Placerat facer possim</h3>
                                            <span>Vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui et everti tamquam suavitate mea.</span>
                                        </figcaption>--%>
                                    </figure>
                                </a>
                            </li>
                            <!-- //Portfolio Item// -->
                            <!-- Portfolio Item -->
                            <li class="portfolio-item col-sm-4 col-xs-6 margin-bottom-40">
                                <a href="#">
                                    <figure class="animate fadeInLeft">
                                        <img alt="image4" src="imagecarousal/construction-image.jpg" />
                                       <%-- <figcaption>
                                            <h3>Nam liber tempor</h3>
                                            <span>Vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui et everti tamquam suavitate mea.</span>
                                        </figcaption>--%>
                                    </figure>
                                </a>
                            </li>
                            <!-- //Portfolio Item// -->
                            <!-- Portfolio Item -->
                            <li class="portfolio-item col-sm-4 col-xs-6 margin-bottom-40">
                                <a href="#">
                                    <figure class="animate fadeIn">
                                        <img alt="image5" src="imagecarousal/1%20(2).jpg" />
                                        <%--<figcaption>
                                            <h3>Donec non urna</h3>
                                            <span>Vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui et everti tamquam suavitate mea.</span>
                                        </figcaption>--%>
                                    </figure>
                                </a>
                            </li>
                            <!-- //Portfolio Item// -->
                            <!-- Portfolio Item -->
                            <li class="portfolio-item col-sm-4 col-xs-6 margin-bottom-40">
                                <a href="#">
                                    <figure class="animate fadeInRight">
                                        <img alt="image6" src="imagecarousal/1%20(1).jpg" />
                                       <%-- <figcaption>
                                            <h3>Nullam consectetur</h3>
                                            <span>Vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui et everti tamquam suavitate mea.</span>
                                        </figcaption>--%>
                                    </figure>
                                </a>
                            </li>
                            <!-- //Portfolio Item// -->
                        </ul>
                    </div>
                </div>
            </div>
            <!-- End Portfolio -->
            <!-- === END CONTENT === -->
            <!-- === BEGIN FOOTER === -->
            <div id="base">
                <div class="container bottom-border padding-vert-30">
                    <div class="row">
                        <!-- Disclaimer -->
                        <div class="col-md-4">
                            <h3 class="class margin-bottom-10">Expand Your Construction</h3>
                             <p>
                                   Plan Rooms</p>
                                <p>Procurement and Equipment
</p>
                        </div>
                        <!-- End Disclaimer -->
                        <!-- Contact Details -->
                        <div class="col-md-4 margin-bottom-20">
                            <h3 class="margin-bottom-10" id="contact">Contact Details</h3>
                            <p>
                                <span class="fa-phone">Telephone:</span>1-800-123-4567
                                <br/>
                                <span class="fa-envelope">Email:</span>
                                <a href="#">info@construction.com</a>
                                <br/>
                                <span class="fa-link">Website:</span>
                                <a href="#">www.example.com</a>
                            </p>
                            <p>The Dunes, Top Road,
                                <br/>Strandhill,
                                <br/>Co. Sligo,
                                <br/>Ireland</p>
                        </div>
                        <!-- End Contact Details -->
                        <!-- Sample Menu -->
                        <div class="col-md-4 margin-bottom-20">
                            <h3 class="margin-bottom-10"> Menu</h3>
                            <ul class="menu">
                                <li>
                                    <a class="fa-tasks" href="#">Tools And References</a>
                                </li>
                                <li>
                                    <a class="fa-users" href="#">Privacy Policy</a>
                                </li>
                               <%-- <li>
                                    <a class="fa-signal" href="#">Velit esse molestie</a>
                                </li>
                                <li>
                                    <a class="fa-coffee" href="#">Nam liber tempor</a>
                                </li>--%>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <!-- End Sample Menu -->
                    </div>
                </div>
            </div>
            <!-- Footer -->
            <div id="footer" class="background-grey">
                <div class="container">
                    <div class="row">
                        <!-- Footer Menu -->
                        <div id="footermenu" class="col-md-8">
                           <%-- <ul class="list-unstyled list-inline">
                                <li>
                                    <a href="#" target="_blank">Sample Link</a>
                                </li>
                                <li>
                                    <a href="#" target="_blank">Sample Link</a>
                                </li>
                                <li>
                                    <a href="#" target="_blank">Sample Link</a>
                                </li>
                                <li>
                                    <a href="#" target="_blank">Sample Link</a>
                                </li>
                            </ul>--%>
                        </div>
                        <!-- End Footer Menu -->
                        <!-- Copyright -->
                        <div id="copyright" class="col-md-4">
                            <p class="pull-right">(c) 2014 Your Copyright Info</p>
                        </div>
                        <!-- End Copyright -->
                    </div>
                </div>
            </div>
            <!-- End Footer -->
            <!-- JS -->
            <script type="text/javascript" src="assets/js/jquery.min.js" ></script>
            <script type="text/javascript" src="assets/js/bootstrap.min.js" ></script>
            <script type="text/javascript" src="assets/js/scripts.js"></script>
            <!-- Isotope - Portfolio Sorting -->
            <script type="text/javascript" src="assets/js/jquery.isotope.js"></script>
            <!-- Mobile Menu - Slicknav -->
            <script type="text/javascript" src="assets/js/jquery.slicknav.js"></script>
            <!-- Animate on Scroll-->
            <script type="text/javascript" src="assets/js/jquery.visible.js" charset="utf-8"></script>
            <!-- Sticky Div -->
            <script type="text/javascript" src="assets/js/jquery.sticky.js" charset="utf-8"></script>
            <!-- Slimbox2-->
            <script type="text/javascript" src="assets/js/slimbox2.js" charset="utf-8"></script>
            <!-- Modernizr -->
            <script src="assets/js/modernizr.custom.js" type="text/javascript"></script>
            <!-- End JS -->
         </div>
    </form>
</body>
</html>
