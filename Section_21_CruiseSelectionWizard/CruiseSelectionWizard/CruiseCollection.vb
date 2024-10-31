Public Class CruiseCollection
    Public ReadOnly Property Items As New List(Of Cruise)

    Public Sub New()
        Items.Add(New Cruise(1000, RegionInfo.Names(0), True, 45, "Fjords of Norway, 5 days"))
        Items.Add(New Cruise(1500, RegionInfo.Names(0), True, 30, "Fjords of Norway, 4 days"))
        Items.Add(New Cruise(2000, RegionInfo.Names(0), False, 30, "Scotland, 4 days"))
        Items.Add(New Cruise(2000, RegionInfo.Names(0), False, 25, "Ireland, 4 days"))

        Items.Add(New Cruise(2000, RegionInfo.Names(1), False, 30, "Bahamas, 4 days"))
        Items.Add(New Cruise(1500, RegionInfo.Names(1), True, 45, "Miami to Barbados, 5 days"))
        Items.Add(New Cruise(3000, RegionInfo.Names(1), False, 25, "Cancun to Kingston, 7 days"))
        Items.Add(New Cruise(1700, RegionInfo.Names(1), False, 50, "Miami to Trinidad, 5 days"))

        Items.Add(New Cruise(1500, RegionInfo.Names(2), False, 30, "Alaska = Glacier, 7 days"))
        Items.Add(New Cruise(1500, RegionInfo.Names(2), True, 30, "Alaska, 7 days"))
        Items.Add(New Cruise(1500, RegionInfo.Names(2), False, 30, "Alaska - Kenai Peninsula , 4 days"))
        Items.Add(New Cruise(1500, RegionInfo.Names(2), True, 30, "Alaska, 7 days"))
    End Sub













End Class
