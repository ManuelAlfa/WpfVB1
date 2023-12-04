Option Infer On
Imports AutoMapper


Class MainWindow
    'Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
    '    MessageBox.Show("Hola " & Me.txNombre1.Text.ToString())


    'End Sub
    Private _PersonajesController As PersonajesController
    ' Private ReadOnly omapper As AutoMapper.IMapper
    Public Sub New()
        InitializeComponent()


        _PersonajesController = New PersonajesController()

        Dim results As List(Of PersonajeDTO) = New List(Of PersonajeDTO)()


        AccessTheWebAsync(results)






        '   LoadCollectionData()
    End Sub

    Async Function AccessTheWebAsync(results As List(Of PersonajeDTO)) As Task(Of List(Of PersonajeDTO))


        MyEnvoltorio.CreateMimap()
        Dim lista As Personajes = Await _PersonajesController.GetAllPersonajes()

        Dim lista1 As List(Of Personaje) = lista.results


        'Dim oPersonaje As Personaje

        'For index = 1 To 10
        '    oPersonaje = New Personaje
        '    oPersonaje = lista.results(index)
        '    lista1.Add(oPersonaje)
        'Next



        'Dim results As List(Of PersonajeDTO) = New List(Of PersonajeDTO)

        results = oMapper.Map(Of List(Of Personaje), List(Of PersonajeDTO))(lista1)

        'LoadCollectionData();
        misDatos.ItemsSource = results

        Return results


    End Function


    '    Gravedad	Código	Descripción	Proyecto	Archivo	Línea	Estado suprimido
    'Error BC30518	Error de resolución de sobrecarga porque no se puede llamar a ninguna de las funciones 'Map' a las que se tiene acceso con estos argumentos:
    '    'Public Overloads Function Map(Of TDestination)(source As Object, opts As Action(Of IMappingOperationOptions(Of Object, TDestination))) As TDestination': No se puede inferir el parámetro de tipo 'TDestination'.
    'Public Overloads Function Map(Of TSource, TDestination)(source As TSource, opts As Action(Of IMappingOperationOptions(Of TSource, TDestination))) As TDestination': No se puede inferir el parámetro de tipo 'TSource'.
    'Public Overloads Function Map(Of TSource, TDestination)(source As TSource, opts As Action(Of IMappingOperationOptions(Of TSource, TDestination))) As TDestination': No se puede inferir el parámetro de tipo 'TDestination'.
    'Public Overloads Function Map(Of TSource, TDestination)(source As TSource, destination As TDestination) As TDestination': No se puede inferir el parámetro de tipo 'TSource'.
    'Public Overloads Function Map(Of TSource, TDestination)(source As TSource, destination As TDestination) As TDestination': No se puede inferir el parámetro de tipo 'TDestination'.	WpfVB1	C:\GUARDADESEGURIDAD\WpfVB1\WpfVB1\MainWindow.xaml.vb	65	Activo




    'Private MapperConfiguration config;
    'Public DataService()
    '{
    '    IMapper _Mapper = config.CreateMapper(); 
    '}

    '    Public Static Class MyMapper
    '{
    '    Private Static bool _isInitialized;
    '    Public Static Initialize()
    '    {
    '        If (!_isInitialized)
    '        {
    '            Mapper.Initialize(cfg =>
    '            {
    '                cfg.CreateMap<Db.Student, Dto.StudentDto>();
    '            });
    '            _isInitialized = true;
    '        }
    '    }
    '}
    'Make sure that you use this Class In your data service

    'Public Class DataService
    '{
    '    Public DataService()
    '    {
    '        MyMapper.Initialize();
    '    }

    '    Public List<Dto.StudentDto> GetStudent(int id)
    '    {
    '        Using (var context = New DbContext().GetContext())
    '        {
    '            var student = context.Students.FirstOrDefault(x >= x.Id == id)
    '            var returnDto = Mapper.Map < List < Dto.StudentDto >> (student);
    '            Return returnDto;
    '        }
    '    }
    '}









    Private Function LoadCollectionData() As List(Of Author)
                Dim authors As List(Of Author) = New List(Of Author)()
                authors.Add(New Author() With {
.ID = 101,
.Name = "PEPITO EL HUEVO FRITO",
.BookTitle = "Graphics Programming with GDI+",
.DOB = New DateTime(1975, 2, 23),
.IsMVP = False
})
                authors.Add(New Author() With {
.ID = 201,
.Name = "Mike Gold",
.BookTitle = "Programming C#",
.DOB = New DateTime(1982, 4, 12),
.IsMVP = True
})
                authors.Add(New Author() With {
.ID = 244,
.Name = "Mathew Cochran",
.BookTitle = "LINQ in Vista",
.DOB = New DateTime(1985, 9, 11),
.IsMVP = True
})
                Return authors
            End Function
End Class
