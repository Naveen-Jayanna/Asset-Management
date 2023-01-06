<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrontPage.aspx.cs" Inherits="DIP.FrontPage" %>



<html lang="zxx">

<head>

    <title>Hotel Management Application</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8" />
    <meta name="keywords" content= />
    <script>
        addEventListener("load", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
    <!-- Custom Theme files -->
    <link href="css/bootstrap.css" type="text/css" rel="stylesheet" media="all">
    <link href="css/style.css" type="text/css" rel="stylesheet" media="all">
    <!-- font-awesome icons -->
    <link href="css/fontawesome-all.min.css" rel="stylesheet">
    <!-- //Custom Theme files -->
    <!-- online-fonts -->
	<link href="//fonts.googleapis.com/css?family=Lato:100,300,400,700,900" rel="stylesheet">
   <!-- //online-fonts -->
</head>
<body style="background-color:black">
    <div class="sidenav text-center">
		<div class="side_top">
			<img src="images/about.jpg" alt="news image" class="img-fluid navimg">
			<h1 class="top_hd mt-2"><a href="FrontPage.aspx">Hotel Management</a></h1>
			<p class="top_hdp mt-2">Made Easier</p>
             
        </div>
		<!-- header -->
        <header>
			<div class="nav-top">
				<nav class="mnu mx-auto">
                    <label for="drop" class="toggle">Menu</label>
                    <input type="checkbox" id="drop">
						<ul class="menu">
							<li class="active"><a href="#home" class="scroll">Home</a></li>
							 <li class="mt-sm-3"><a href="Login.aspx" class="scroll">Login</a></li>
							
                        </ul>
				</nav>
			</div>
		</header>
        <!-- //header -->
    </div>
    <div class="main">
        <div class="banner-text-w3ls" id="home">
			<div class="container">
                <div class="mx-auto text-center">
                    <h3>Authenticate to use our functionality
				</h3>
					<p class="banp mx-auto mt-3">Hotel Personnel Only </p>
					<%--<a class="btn btn-primary mt-lg-5 mt-3 agile-link-bnr" href="#about" role="button">Learn More</a>--%>
                </div>
                
                <div class="mx-auto text-center">
                <form id="form1" runat="server">
                <asp:Button ID="btnLogin" runat="server" Text="Login" 
                        class="btn btn-primary mt-lg-5 mt-3 agile-link-bnr" onclick="btnLogin_Click" />
                 </form>
                </div>
            </div>
        </div>
		<!-- about -->

    </div>
   <div>
</div>
<div>
</div>
</body>

</html>


  