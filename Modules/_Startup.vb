' See views: sp_helptext @objname = 'viewname'

Module _Startup
    Sub main()
        setStringConnection("localhost", "MarketStore")

        Application.EnableVisualStyles()
        Application.Run(Home)
    End Sub
End Module
