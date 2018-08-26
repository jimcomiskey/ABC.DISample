Imports Ninject
Imports Ninject.Extensions.Conventions.Syntax
Imports Ninject.Extensions.Conventions

Module ModMain

    Public Sub Main()

        Using kernel = New StandardKernel()

            kernel.Bind(Function(x)
                            Return x.FromAssembliesMatching("ABC.*").SelectAllClasses().BindAllInterfaces()
                        End Function)

            kernel.Bind(Function(x)
                            Return x.FromThisAssembly().
                            SelectAllInterfaces().
                            EndingWith("Factory").
                            BindToFactory().
                            Configure(Function(c) c.InSingletonScope())
                        End Function)

            Dim mainForm = kernel.Get(Of MainForm)

            Application.Run(mainForm)

        End Using



    End Sub

End Module
