Imports System.Collections.Specialized.BitVector32
Imports System.Reflection.Emit

Public Class form1
    Private metroLines As New Dictionary(Of String, List(Of String))()
    Private interchangeStations As New List(Of String)()

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define metro lines
        metroLines("Line 1") = New List(Of String) From {
            "Helwan", "Ain Helwan", "Helwan University", "Wadi Hof", "Hadayek Helwan", "El-Masraa",
            "Tora El-Asmant", "Kozzika", "Tora El-Balad", "Sakanat El-Maadi", "Maadi", "Hadayek El-Maadi",
            "Dar El-Salam", "El-Zahraa", "Mar Girgis", "El-Malek El-Saleh", "Al-Sayeda Zeinab",
            "Saad Zaghloul", "Sadat", "Nasser", "Orabi", "Al-Shohadaa", "Ghamra", "El-Demerdash",
            "Manshiet El-Sadr", "Kobri El-Qobba", "Hammamat El-Qobba", "Saray El-Qobba",
            "Hadayeq El-Zaitoun", "Helmeyet El-Zaitoun", "El-Matareyya", "Ain Shams",
            "Ezbet El-Nakhl", "El-Marg", "New El-Marg"
        }

        metroLines("Line 2") = New List(Of String) From {
            "Shubra El-Kheima", "Kolleyet El-Zeraa", "Mezallat", "Khalafawy", "Saint Teresa", "Rod El-Farag",
            "Masarra", "Al-Shohadaa", "Attaba", "Mohamed Naguib", "Sadat", "Opera", "Dokki", "El-Behoos", "Cairo University", "Faisal",
            "Giza", "Omm El-Masryeen", "Sakiat Mekki", "El-Monib"
        }

        metroLines("Line 3") = New List(Of String) From {
            "Adly Mansour", "El-Haykestep", "Omar Ibn El-Khattab", "Qobaa", "Hesham Barakat", "El-Nozha",
            "Nadi El-Shams", "Alf Maskan", "Heliopolis Square", "Haroun", "Al-Ahram", "Koleyet El-Banat",
            "Cairo Stadium", "Fair Zone", "Abbassia", "Abdou Pasha", "El-Geish", "Bab El-Shaaria",
            "Attaba", "Nasser", "Maspero", "Safaa Hegazy", "Kit Kat"
        }
        metroLines("Line 4") = New List(Of String) From {
            "Rod El-Farag", "Ring Road", "El-Qawmia", "El-Bohy", "Imbaba", "Sudan", "Kit Kat", "Tawfikia", "Wadi El-Nile",
            "Gamet El-Dowel" , "Boulak El-Dakrour", "Cairo University"}

        ' Define interchange stations
        interchangeStations = New List(Of String) From {"Al-Shohadaa", "Sadat", "Attaba", "Nasser", "Kit Kat", "Cairo University"}

        ' Add stations to dropdown lists
        For Each lineStations In metroLines.Values
            For Each station In lineStations
                If Not cbStart.Items.Contains(station) Then cbStart.Items.Add(station)
                If Not cbEnd.Items.Contains(station) Then cbEnd.Items.Add(station)
            Next
        Next
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If cbStart.SelectedItem Is Nothing OrElse cbEnd.SelectedItem Is Nothing Then
            lblResult.Text = "Please select both start and end stations."
            Return
        End If

        Dim startStation As String = cbStart.SelectedItem.ToString()
        Dim endStation As String = cbEnd.SelectedItem.ToString()
        Dim result = CalculateShortestPathWithPath(startStation, endStation)

        Dim stationCount As Integer = result.Item1
        Dim path As List(Of String) = result.Item2
        Dim totalMinutes As Double = stationCount * 3
        Dim time As String = ConvertMinutesToTime(totalMinutes)

        If stationCount <> -1 Then
            lblResult.Text = $"Shortest path: {stationCount} stations."

            ' Highlight interchange stations
            Dim formattedPath As New List(Of String)
            For Each station In path
                If interchangeStations.Contains(station) Then
                    formattedPath.Add($"({station})") ' Use a special format or symbol
                Else
                    formattedPath.Add(station)
                End If
            Next

            pathlbl.Text = $"Path: {String.Join(" → ", formattedPath)}"
        Else
            lblResult.Text = "No path found between the selected stations."
            pathlbl.Text = ""
        End If

        timelbl.Text = $"Total Time: {time}"

        If stationCount <= 9 Then
            tecketlbl.Text = "Ticket Price: 8"
        ElseIf stationCount <= 16 Then
            tecketlbl.Text = "Ticket Price: 10"
        ElseIf stationCount <= 23 Then
            tecketlbl.Text = "Ticket Price: 15"
        Else
            tecketlbl.Text = "Ticket Price: 20"
        End If
    End Sub

    Private Function CalculateShortestPath(startStation As String, endStation As String) As Integer
        ' BFS to find the shortest path
        Dim queue As New Queue(Of Tuple(Of String, Integer))()
        Dim visitedStations As New HashSet(Of String)()

        queue.Enqueue(Tuple.Create(startStation, 0))
        visitedStations.Add(startStation)

        While queue.Count > 0
            Dim current = queue.Dequeue()
            Dim currentStation = current.Item1
            Dim currentCount = current.Item2

            If currentStation = endStation Then
                Return currentCount
            End If

            Dim neighbors = GetNeighbors(currentStation)
            For Each neighbor In neighbors
                If Not visitedStations.Contains(neighbor) Then
                    visitedStations.Add(neighbor)
                    queue.Enqueue(Tuple.Create(neighbor, currentCount + 1))
                End If
            Next
        End While

        Return -1 ' No path found
    End Function
    Private Function CalculateShortestPathWithPath(startStation As String, endStation As String) As Tuple(Of Integer, List(Of String))
        Dim queue As New Queue(Of Tuple(Of String, Integer, List(Of String)))()
        Dim visitedStations As New HashSet(Of String)()

        queue.Enqueue(Tuple.Create(startStation, 0, New List(Of String) From {startStation}))
        visitedStations.Add(startStation)

        While queue.Count > 0
            Dim current = queue.Dequeue()
            Dim currentStation = current.Item1
            Dim currentCount = current.Item2
            Dim path = current.Item3

            If currentStation = endStation Then
                Return Tuple.Create(currentCount, path)
            End If

            Dim neighbors = GetNeighbors(currentStation)
            For Each neighbor In neighbors
                If Not visitedStations.Contains(neighbor) Then
                    visitedStations.Add(neighbor)
                    Dim newPath = New List(Of String)(path) From {neighbor}
                    queue.Enqueue(Tuple.Create(neighbor, currentCount + 1, newPath))
                End If
            Next
        End While

        Return Tuple.Create(-1, New List(Of String)()) ' No path found
    End Function

    Private Function GetNeighbors(station As String) As List(Of String)
        Dim neighbors As New List(Of String)()

        ' Get adjacent stations on the same line
        For Each line In metroLines.Values
            If line.Contains(station) Then
                Dim index = line.IndexOf(station)
                If index > 0 Then neighbors.Add(line(index - 1))
                If index < line.Count - 1 Then neighbors.Add(line(index + 1))
            End If
        Next

        ' Add interchange station neighbors
        If interchangeStations.Contains(station) Then
            For Each line In metroLines.Values
                If line.Contains(station) Then
                    Dim index = line.IndexOf(station)
                    If index > 0 Then neighbors.Add(line(index - 1))
                    If index < line.Count - 1 Then neighbors.Add(line(index + 1))
                End If
            Next
        End If

        Return neighbors.Distinct().ToList() ' Remove duplicates

    End Function
    Private Function GetInterchangeStations(startStation As String, endStation As String) As String

        Dim queue As New Queue(Of Tuple(Of String, List(Of String)))()
        Dim visitedStations As New HashSet(Of String)()


        queue.Enqueue(Tuple.Create(startStation, New List(Of String)()))
        visitedStations.Add(startStation)

        While queue.Count > 0
            Dim current = queue.Dequeue()
            Dim currentStation = current.Item1
            Dim interchangePath = current.Item2
            If currentStation = endStation Then
                Return If(interchangePath.Any(), String.Join(", ", interchangePath), "No interchanges needed.")
            End If
            Dim neighbors = GetNeighbors(currentStation)
            For Each neighbor In neighbors
                If Not visitedStations.Contains(neighbor) Then
                    visitedStations.Add(neighbor)
                    Dim newInterchangePath = New List(Of String)(interchangePath)
                    If interchangeStations.Contains(currentStation) AndAlso Not newInterchangePath.Contains(currentStation) Then
                        newInterchangePath.Add(currentStation)
                    End If

                    queue.Enqueue(Tuple.Create(neighbor, newInterchangePath))
                End If
            Next
        End While

        Return "No path found between the selected stations."
    End Function
    Private Function CalculateJourneyTime(startStation As String, endStation As String) As String

        Const averageTimePerStation As Double = 3
        Dim stationCount As Integer = CalculateShortestPath(startStation, endStation)
        If stationCount = -1 Then
            Return "No path found between the selected stations."
        End If
        Dim totalTime As Double = stationCount * averageTimePerStation
        Return totalTime
    End Function
    Public Function ConvertMinutesToTime(minutes As Integer) As String
        Dim hours As Integer = minutes \ 60
        Dim remainingMinutes As Integer = minutes Mod 60
        Dim seconds As Integer = 0 ' إذا كنت تريد تضمين الثواني، يمكنك تعديل القيمة

        Return $"{hours:D2}:{remainingMinutes:D2}:{seconds:D2}"
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Map.Show()
    End Sub
End Class