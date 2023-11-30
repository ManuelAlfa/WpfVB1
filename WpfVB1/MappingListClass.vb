Imports AutoMapper


Public Class DbItem
        Public Property Id As Integer
        Public Property Name As String
    End Class

    Public Class ViewItem
        Public Property Id As Integer
        Public Property Name As String
    End Class

    Public Class PagedList(Of T)
        Inherits List(Of T)

        Public Property TotalItems As Integer
        Public Property CurrentPage As Integer
        Public Property PageSize As Integer
    End Class

    Class Program
        Private Shared Sub Main(ByVal args As String())
            MapItems()
        End Sub

    Public Shared Sub MapItems()

        '    Dim value = oMapper.CreateMap(Of DbItem, ViewItem)()
        '    oMapper.CreateMap(Of PagedList(Of DbItem), PagedList(Of ViewItem))().AfterMap(Function(s, d) Mapper.Map(Of List(Of DbItem), List(Of ViewItem))(s, d))
        '    Dim dbList = New PagedList(Of DbItem) From {
        '    New DbItem With {
        '        .Id = 1,
        '        .Name = "a"
        '    },
        '    New DbItem With {
        '        .Id = 2,
        '        .Name = "b"
        '    }
        '}
        '    dbList.TotalItems = 2
        '    dbList.CurrentPage = 1
        '    dbList.PageSize = 10
        '    Dim viewList = Mapper.Map(Of PagedList(Of DbItem), PagedList(Of ViewItem))(dbList)
        '    Console.WriteLine(viewList.TotalItems)
        '    Console.WriteLine(viewList.CurrentPage)
        '    Console.WriteLine(viewList.PageSize)
        '    Console.WriteLine(viewList(0).Id & " " + viewList(0).Name)
        '    Console.WriteLine(viewList(1).Id & " " + viewList(1).Name)
        '    Console.ReadLine()
    End Sub
End Class


'The Static version Of the CreateMap method was deprecated In 4.2, Then removed from the API In version 5.0. Jimmy Bogard talks about this In more detail In this blog post.

'The New technique For mapping Is non-Static, Like this(code Is From the post):

'var config = New MapperConfiguration(cfg >= {
'    cfg.CreateMap < source, dest > ();
'});

'IMapper mapper = config.CreateMapper();
'var source = New Source();
'var dest = mapper.Map < source, Dest>(source);