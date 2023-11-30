Imports AutoMapper

Module MyEnvoltorio


    Private _isInitialized As Boolean
    Public oMapper As AutoMapper.IMapper
    Private oMapConfig As AutoMapper.MapperConfiguration


    Public Sub CreateMimap()
        If Not _isInitialized Then


            'Dim DataReaderMapper As IMapper = New MapperConfiguration(Sub(cfg)
            '                                                              cfg.CreateMap(Of Personajes, PersonajeDTO)()
            '                                                          End Sub).CreateMapper()
            oMapper = New MapperConfiguration(Sub(cfg)
                                                  cfg.CreateMap(Of Personaje, PersonajeDTO)()
                                              End Sub).CreateMapper()





            _isInitialized = True
        End If
    End Sub




End Module