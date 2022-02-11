<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="Bootstrap.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <title></title>
</head>
<body>

    <ol class="list-group">
        <button type="button" class="list-group-item list-group-item-action active" aria-current="true">The current button</button>
        <button type="button" class="list-group-item list-group-item-action">A second item</button>
        <button type="button" class="list-group-item list-group-item-action">A third button item
            <span class="badge bg-primary rounded-pill">14</span>
        </button>
        <button type="button" class="list-group-item list-group-item-danger">A fourth button item</button>
        <button type="button" class="list-group-item list-group-item-action" disabled>A disabled button item</button>
    </ol>
    <ul class="list-group list-group-horizontal-sm">
        <li class="list-group-item">
            An item
            <input class="form-check-input me-1" type="checkbox" value="" aria-label="...">
        </li>
        <li class="list-group-item">
            A second item
            <input class="form-check-input me-1" type="checkbox" value="" aria-label="...">
        </li>
        <li class="list-group-item">
            A third item
            <input class="form-check-input me-1" type="checkbox" value="" aria-label="...">
        </li>
    </ul>

</body>
</html>
