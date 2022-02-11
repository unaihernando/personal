<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="JQuery.aspx.vb" Inherits="Bootstrap.JQuery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $("p").click(function () {
                $(this).hide();
            });
        });
    </script>
    <script>
        $(document).ready(function () {
            $("h2").click(function () {
                $(this).hide();
            });
        });
    </script>
    <title></title>
</head>
<body>
    <p>If you click on me, I will disappear.</p>
    <p>Click me away!</p>
    <p>Click me too!</p>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Contextual Colors</h2>
            <p>Use the contextual classes to provide "meaning through colors":</p>
            <p class="text-muted">This text is muted.</p>
            <p class="text-primary">This text is important.</p>
            <p class="text-success">This text indicates success.</p>
            <p class="text-info">This text represents some information.</p>
            <p class="text-warning">This text represents a warning.</p>
            <p class="text-danger">This text represents danger.</p>
            <p class="text-secondary">Secondary text.</p>
            <p class="text-dark">This text is dark grey.</p>
            <p class="text-body">Default body color (often black).</p>
            <p class="text-light">This text is light grey (on white background).</p>
            <p class="text-white">This text is white (on white background).</p>
            <h2>Alerts</h2>
            <p>Alerts are created with the .alert class, followed by a contextual color classes:</p>
            <div class="alert alert-success">
                <strong>Success!</strong> This alert box could indicate a successful or positive action.
            </div>
            <div class="alert alert-info">
                <strong>Info!</strong> This alert box could indicate a neutral informative change or action.
            </div>
            <div class="alert alert-warning">
                <strong>Warning!</strong> This alert box could indicate a warning that might need attention.
            </div>
        </div>
    </form>
</body>
</html>
