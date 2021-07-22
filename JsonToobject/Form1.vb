Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim request = DirectCast(WebRequest.Create("https://covid19.th-stat.com/json/covid19v2/getTodayCases.json?fbclid=IwAR0D9Bo3pVW7lM_q-uqwlWeGly2BrVcQJIthYvRnbs2U6kYNz8N62ZW6fbI"), HttpWebRequest)

        Dim response = request.GetResponse()
        Dim reader As New StreamReader(response.GetResponseStream())
        Dim readerString As String = reader.ReadToEnd

        Dim covid19 As Covid = JsonConvert.DeserializeObject(Of Covid)(readerString)

        Label1.Text = covid19.Confirmed
        Label2.Text = covid19.Recovered
        Label3.Text = covid19.Hospitalized
        Label4.Text = covid19.Deaths
        Label5.Text = covid19.NewConfirmed
        Label6.Text = covid19.NewRecovered
        Label7.Text = covid19.NewHospitalized
        Label8.Text = covid19.NewDeaths
        Label9.Text = covid19.UpdateDate
        Label10.Text = covid19.DevBy

    End Sub
End Class

Public Class Covid
    Public Property Confirmed As String
    Public Property Recovered As String
    Public Property Hospitalized As String
    Public Property Deaths As String
    Public Property NewConfirmed As String
    Public Property NewRecovered As String
    Public Property NewHospitalized As String
    Public Property NewDeaths As String
    Public Property UpdateDate As String
    Public Property DevBy As String
End Class

