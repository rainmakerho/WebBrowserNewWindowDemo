Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim tab As New TabPage
            tab.Text = "Loading..."
            Dim brws As New ExtendedWebBrowser
            brws.Dock = DockStyle.Fill
            brws.ScriptErrorsSuppressed = True
            brws.Tag = tab
            brws.Parent = tab

            'InitWebBrowserEvents(brws)
            Me.TabControl1.TabPages.Add(tab)
            Me.TabControl1.SelectedTab = tab
            brws.Navigate("https://dotblogs.com.tw/rainmaker/2017/02/16/232531")
        Catch ex As Exception

        End Try
    End Sub




    Sub InitWebBrowserEvents(wb As ExtendedWebBrowser)
        AddHandler wb.NewWindow2, AddressOf WebBrowser_NewWindow2
    End Sub

    Private Sub WebBrowser_NewWindow2(sender As Object, e As NewWindow2EventArgs)
        Try
            Dim tab As New TabPage
            tab.Text = "Loading..."
            Dim brws As New ExtendedWebBrowser
            brws.Dock = DockStyle.Fill
            brws.ScriptErrorsSuppressed = True
            brws.Tag = tab
            brws.Parent = tab
            e.PPDisp = brws.Application
            InitWebBrowserEvents(brws)
            Me.TabControl1.TabPages.Add(tab)
            Me.TabControl1.SelectedTab = tab

        Catch ex As Exception

        End Try
    End Sub
End Class


