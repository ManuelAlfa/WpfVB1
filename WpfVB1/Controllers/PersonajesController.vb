

Option Infer On
Imports System.Net.Http

Imports Newtonsoft.Json


'Public Class DataService
'    Public Sub New()
'        MyMapper.Initialize()
'    End Sub

'    Public Function GetStudent(ByVal id As Integer) As List(Of Dto.StudentDto)
'        Using context = New DbContext().GetContext()
'            Dim student = context.Students.FirstOrDefault(Function(x) x.Id = id)
'            Dim returnDto = Mapper.Map(Of List(Of Dto.StudentDto))(student)
'            Return returnDto
'        End Using
'    End Function
'End Class

Public Class PersonajesController

    Private client As HttpClient




    Public Sub New()

        client = New HttpClient()

        'CreateMap(Of Src_OrderALineItem, Dest_OrderB)()

        'CreateMap(Of Src_OrderA, List(Of Dest_OrderB))() _
        '    .ConstructProjectionUsing(
        '        Function(Src1) Src1.List_Src_OrderALineItem.Select(Function(Src2) New Dest_OrderB _
        '            With {.CustomerName = Src1.CustomerName,
        '                    .OrderID = Src1.OrderID,
        '                    .ItemName = Src2.ItemName,
        '                    .ItemQty = Src2.ItemQty,
        '                    .Price = Src2.Price}
        '                    ).ToList())


    End Sub


    Public Async Function GetAllPersonajes() As Task(Of Personajes)

        Try

            Dim _personajes As Personajes = New Personajes()
            Dim response = Await client.GetAsync("https://rickandmortyapi.com/api/character/")

            Dim responseJson As String = Await response.Content.ReadAsStringAsync()
            _personajes = JsonConvert.DeserializeObject(Of Personajes)(value:=responseJson)

            Return _personajes


        Catch ex As ArgumentException

            Throw ex
            'Return Nothing

        End Try


    End Function







End Class
