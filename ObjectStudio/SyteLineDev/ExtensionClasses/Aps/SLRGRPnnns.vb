﻿Option Explicit On
Option Strict On

Imports Mongoose.IDO
Imports Mongoose.IDO.Protocol
Imports Mongoose.IDO.DataAccess
Imports Mongoose.Core.Common

<IDOExtensionClass("SLRGRPnnns")> _
Public Class SLRGRPnnns
    Inherits ExtensionClassBase

    <IDOMethod(MethodFlags.None)> _
    Public Sub SetAlternative(ByVal altno As String)
        Using db As AppDB = IDORuntime.Context.CreateAppDB()
            db.SetSessionVariable("ApsAltern", altno)
        End Using
    End Sub

    Public Overrides Sub SetContext(ByVal context As Mongoose.IDO.IIDOExtensionClassContext)
        MyBase.SetContext(context)
        AddHandler Me.Context.IDO.PreLoadCollection, AddressOf Me.HandlePreLoadCollection
        AddHandler Me.Context.IDO.PreUpdateCollection, AddressOf Me.HandlePreUpdateCollection
    End Sub

    Private Sub HandlePreLoadCollection(ByVal sender As Object, ByVal args As IDOEventArgs)
        Dim request As LoadCollectionRequestData = CType(args.RequestPayload, LoadCollectionRequestData)
        Using db As AppDB = IDORuntime.Context.CreateAppDB()
            Dim altno As Integer = CType(db.GetSessionVariable("ApsAltern"), Integer)
            request.IDOName = "TABLE!" + "RGRP" + altno.ToString("000")
            args.ResponsePayload = Me.Context.Commands.LoadCollection(request)
        End Using
    End Sub
    Private Sub HandlePreUpdateCollection(ByVal sender As Object, ByVal args As IDOEventArgs)
        Dim request As UpdateCollectionRequestData = CType(args.RequestPayload, UpdateCollectionRequestData)
        Dim actionMask as UpdateAction = CType(args, IDOUpdateEventArgs).ActionMask
        Dim item As IDOUpdateItem
        Dim newItem As IDOUpdateItem
        Dim altno As Integer
        Dim newRequest As UpdateCollectionRequestData = New UpdateCollectionRequestData

        Using db As AppDB = IDORuntime.Context.CreateAppDB()
            altno = CType(db.GetSessionVariable("ApsAltern"), Integer)
        End Using

        newRequest.InitFrom(request)
        For Each item In request.Items
            If (item.Action and actionMask) = item.Action
                newItem = item.Clone(false)
                newRequest.Items.Add(newItem)

                If (item.Action = Mongoose.IDO.Protocol.UpdateAction.Delete)
                   Dim sRGID As String
                   Dim Infobar As string = nothing
                   sRGID = item.Properties("RGID").Value
                   Me.Invoke("RgrpDelSp", sRGID, altno.ToString(), Infobar)
                End If
            End If
        Next

        newRequest.IDOName = "TABLE!" + "RGRP" + altno.ToString("000")
        args.ResponsePayload = Me.Context.Commands.UpdateCollection(newRequest)
    End Sub


End Class
