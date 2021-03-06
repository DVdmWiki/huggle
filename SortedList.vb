﻿'This is a source code or part of Huggle project

'Copyright (C) 2011 Huggle team

'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.

'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.


Class SortedList(Of T)

    Implements IEnumerable(Of T)

    'Implements a generic sorted list
    'Differs from System.Collections.Generic.SortedList in that it stores a list of objects, not key-value pairs
    'and tolerates changes to items' sort orders provided they are removed and re-added

    Private Items As List(Of T), Comparer As IComparer(Of T)

    Public Sub New(ByVal Comparer As IComparer(Of T))
        Items = New List(Of T)
        Me.Comparer = Comparer
    End Sub

    Default Public ReadOnly Property Item(ByVal Index As Integer) As T
        Get
            If Items.Count > Index Then Return Items(Index) Else Return Nothing
        End Get
    End Property

    Public Sub Add(ByVal Item As T)
        If Not Items.Contains(Item) Then

            'Binary insertion sort
            Dim a As Integer = 0, b As Integer = Items.Count, n As Integer
            Dim Curr As Integer = 0
            While a <> b And Curr < Misc.GlExcess
                n = CInt(Math.Ceiling((b + a) \ 2))
                If Comparer.Compare(Item, Items(n)) > 0 Then a = n + 1 Else b = n
                Curr = Curr + 1
            End While

            Items.Insert(a, Item)
        End If
    End Sub

    Public Sub Clear()
        Items.Clear()
    End Sub

    Public ReadOnly Property Contains(ByVal Item As T) As Boolean
        Get
            Return Items.Contains(Item)
        End Get
    End Property

    Public ReadOnly Property Count() As Integer
        Get
            Return Items.Count
        End Get
    End Property

    Public Sub Remove(ByVal Item As T)
        If Items.Contains(Item) Then Items.Remove(Item)
    End Sub

    Public Sub RemoveAt(ByVal Index As Integer)
        If Items.Count > Index Then Items.RemoveAt(Index)
    End Sub

    Public Function GetEnumerator() As IEnumerator(Of T) Implements IEnumerable(Of T).GetEnumerator
        Return Items.GetEnumerator
    End Function

    Public Function GetEnumerator1() As Collections.IEnumerator Implements Collections.IEnumerable.GetEnumerator
        Return Items.GetEnumerator
    End Function

End Class
