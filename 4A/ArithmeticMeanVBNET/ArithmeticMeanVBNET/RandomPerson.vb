Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.Text
Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization

Public Class Education
    Public Property certificate As String
    Public Property university As String
End Class

Public Class Marriage
    Public Property married As Boolean
End Class

Public Class OnlineInfo
    Public Property email As String
    Public Property ip_address As String
    Public Property ipv6_address As String
    Public Property password As String
    Public Property password_md5 As String
    Public Property user_agent As String
    Public Property username As String
End Class

Public Class Personal
    Public Property age As Integer
    Public Property blood As String
    Public Property born As Object
    Public Property born_place As String
    Public Property cellphone As String
    Public Property city As String
    Public Property country As String
    Public Property eye_color As String
    Public Property father_name As String
    Public Property gender As String
    Public Property height As String
    Public Property last_name As String
    Public Property name As String
    Public Property national_code As String
    Public Property religion As String
    Public Property system_id As String
    Public Property weight As Integer
End Class

Public Class Work
    Public Property country_code As String
    Public Property insurance As Boolean
    Public Property position As String
    Public Property salary As String
End Class

Public Class Person
    Public Property education As Education
    Public Property marriage As Marriage
    Public Property online_info As OnlineInfo
    Public Property personal As Personal
    Public Property work As Work
End Class

Public Class ExamplePerson
    Public Property person As Person
End Class

Public Class RandomPerson
    Public Shared url As String = "https://pipl.ir/v1/getPerson"

    Public Shared Function Generate() As Person
        Dim jsonString As String = String.Empty
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.AutomaticDecompression = DecompressionMethods.GZip

        Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

            Using stream As Stream = response.GetResponseStream()

                Using reader As StreamReader = New StreamReader(stream)
                    jsonString = reader.ReadToEnd()
                End Using
            End Using
        End Using

        Dim jss As New JavaScriptSerializer()
        Dim EP As ExamplePerson = jss.Deserialize(Of ExamplePerson)(jsonString)
        Return EP.person
    End Function
End Class
