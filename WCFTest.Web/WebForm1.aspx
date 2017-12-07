<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WCFTest.Web.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="js/jquery-1.4.2.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $('#btnTest').click(function (e) {
                e.preventDefault();
                $.ajax({
                    type: "POST", 
                    url: "http://localhost:31654/EmployeeService.svc/employee",
                    contentType: "application/json;charset=utf-8",
                    dataType: "json",
                    data: '{"Id":"009","Grade":"G8","Department":"风险部","Name":"Tommy"}',
                    success: function (data)
                    {
                        $('#divResponse').html("");
                        $.each(data, function (i) {
                            $('#divResponse').append("Id:" + data[i].Id + ",Name:" + data[i].Name + ",Grade:" + data[i].Grade + ",Department:" + data[i].Department + "<br/>");
                        });
                    },
                    error: function ()
                    {
                        alert("error");
                    }
                });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="divResponse"></div>
        <asp:Button ID="btnTest" runat="server" Text="Test WCF REST API" />
    </div>
    </form>
</body>
</html>
