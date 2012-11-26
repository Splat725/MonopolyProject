Public Class positions

    '' Locations is now a property.
    '' To access the point for a specific location:

    '' mPoint = Locations.item(1..40)
    '' ... where item 1 is what I'm assuming will be the coords for "GO"

    Public ReadOnly Property Locations() As Collection
        Get
            Static mCollection As Collection

            If mCollection Is Nothing Then
                mCollection = New Collection
                '' TO DO:  Load the point coords.
                '' This would best be done from an external file or from the project's settings.
                '' For now we just populate them all with the same value.
                Dim i As Long
                For i = 1 To 40
                    mCollection.Add(New Point(770, 825))
                Next
            End If
            Locations = mCollection
        End Get
    End Property

    ''Public Sub Locations()
    ''    Dim loc1_1 As New Point(770, 825)
    ''    Dim loc2_1 As New Point
    ''    Dim loc3_1 As New Point
    ''    Dim loc4_1 As New Point
    ''    Dim loc5_1 As New Point
    ''    Dim loc6_1 As New Point
    ''    Dim loc7_1 As New Point
    ''    Dim loc8_1 As New Point
    ''    Dim loc9_1 As New Point
    ''    Dim loc10_1 As New Point
    ''    Dim loc11_1 As New Point
    ''    Dim loc12_1 As New Point
    ''    Dim loc13_1 As New Point
    ''    Dim loc14_1 As New Point
    ''    Dim loc15_1 As New Point
    ''    Dim loc16_1 As New Point
    ''    Dim loc17_1 As New Point
    ''    Dim loc18_1 As New Point
    ''    Dim loc19_1 As New Point
    ''    Dim loc20_1 As New Point
    ''    Dim loc21_1 As New Point
    ''    Dim loc22_1 As New Point
    ''    Dim loc23_1 As New Point
    ''    Dim loc24_1 As New Point
    ''    Dim loc25_1 As New Point
    ''    Dim loc26_1 As New Point
    ''    Dim loc27_1 As New Point
    ''    Dim loc28_1 As New Point
    ''    Dim loc29_1 As New Point
    ''    Dim loc30_1 As New Point
    ''    Dim loc31_1 As New Point
    ''    Dim loc32_1 As New Point
    ''    Dim loc33_1 As New Point
    ''    Dim loc34_1 As New Point
    ''    Dim loc35_1 As New Point
    ''    Dim loc36_1 As New Point
    ''    Dim loc37_1 As New Point
    ''    Dim loc38_1 As New Point
    ''    Dim loc39_1 As New Point
    ''    Dim loc40_1 As New Point

    ''End Sub
End Class
