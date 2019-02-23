<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Chefdog.WebControls.SampleWebsite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Chefdog Server Controls sample</h1>
        <p class="lead"></p>
        <p>Author: M.A. van Zuijlen</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                <label for="exampleFormControlSelect1">Example select</label>
                <cfg:WebDropdownControl runat="server" DataToggle="filter" CssClass="cfg-dropdown-control form-control">
                    <DropdownItems>
                        <cfg:WebDropdownItem ItemValue="Test01" ItemText="Test01"></cfg:WebDropdownItem>
                        <cfg:WebDropdownItem ItemValue="Test02" ItemText="Test02" IsSelected="true"></cfg:WebDropdownItem>
                        <cfg:WebDropdownItem ItemValue="Test03" ItemText="Test03"></cfg:WebDropdownItem>
                    </DropdownItems>
                </cfg:WebDropdownControl>
            </div>
        </div>
    </div>

</asp:Content>
