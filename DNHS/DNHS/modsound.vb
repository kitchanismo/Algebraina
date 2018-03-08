﻿Imports System.Text
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Runtime.CompilerServices

Module modsound
    Dim mAlias As String
    Dim mPath As String

    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer ' for typing sounds e.g wav files

    Public Sub create_sound(ByVal stateInfo As Object)

        Select Case stateInfo(0)
            Case 1
                mAlias = "shoot"
                mPath = My.Application.Info.DirectoryPath & "\soundeffects\shoot.wav"
            Case 2
                mAlias = "hit"
                mPath = My.Application.Info.DirectoryPath & "\bgmusic\bg.mp3"
            Case 3
                mAlias = "explosion"
                mPath = My.Application.Info.DirectoryPath & "\soundeffects\explosion.wav"
            Case 4
                mAlias = "laser"
                mPath = My.Application.Info.DirectoryPath & "\soundeffects\laser.wav"
            Case 5
                mAlias = "buzz"
                mPath = My.Application.Info.DirectoryPath & "\soundeffects\buzz.wav"
            Case 6
                mAlias = "slider"
                mPath = My.Application.Info.DirectoryPath & "\soundeffects\slider.wav"
            Case 7
                mAlias = "btn"
                mPath = My.Application.Info.DirectoryPath & "\soundeffects\btn.wav"
            Case 8
                mAlias = "tick"
                mPath = My.Application.Info.DirectoryPath & "\soundeffects\tick.wav"
            Case 9
                mAlias = "car"
                mPath = My.Application.Info.DirectoryPath & "\bgmusic\bg.mp3"
            Case 10
                mAlias = "stop"
                mPath = My.Application.Info.DirectoryPath & "\soundeffects\stop.wav"
            Case 11
                mAlias = "yey"
                mPath = My.Application.Info.DirectoryPath & "\soundeffects\yey.wav"
            Case 12
                mAlias = "clap"
                mPath = My.Application.Info.DirectoryPath & "\soundeffects\clap.wav"

        End Select
        mciSendString("close " & mAlias, CStr(0), 0, 1)
        mciSendString("Open " & Chr(34) & mPath & Chr(34) & " alias " & mAlias, CStr(0), 0, 0)
        mciSendString("play " & mAlias, CStr(0), 0, 0)

    End Sub

    Sub ShootEffects()
        If togSE = True Then
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf create_sound), {1})
            Thread.Sleep(100)
        End If
    End Sub
    Sub HitEffects()
        If togSE = True Then
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf create_sound), {2})
            Thread.Sleep(100)
        End If
    End Sub
    Sub ExplosionEffects()
        ' If togSE = True Then
        ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf create_sound), {3})
        Thread.Sleep(100)
        ' End If
    End Sub
    Sub LaserEffects()
        If togSE = True Then
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf create_sound), {4})
            Thread.Sleep(100)
        End If
    End Sub
    Sub BuzzEffects()
        ' If togSE = True Then
        ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf create_sound), {5})
        Thread.Sleep(100)
        'End If
    End Sub
    Sub SliderEffects()
        ' If togSE = True Then
        ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf create_sound), {6})
        Thread.Sleep(100)
        ' End If
    End Sub
    Sub ClickEffects()
        'If togSE = True Then
        ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf create_sound), {7})
        Thread.Sleep(100)
        ' End If
    End Sub
    Sub TickEffects()
        'If togSE = True Then
        ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf create_sound), {8})
        Thread.Sleep(100)
        'End If
    End Sub
    Sub YeyEffects()
        'If togSE = True Then
        ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf create_sound), {11})
        Thread.Sleep(100)
        'End If
    End Sub
    Sub ClapEffects()
        'If togSE = True Then
        ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf create_sound), {12})
        Thread.Sleep(100)
        'End If
    End Sub
    Sub BGEffects()
        If togSE = True Then
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf create_sound), {10})
            Thread.Sleep(100)
        End If
    End Sub
    Sub StopEffects()
        If togSE = True Then
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf create_sound), {10})
            Thread.Sleep(100)
        End If
    End Sub
    Sub BGMMenu(ByVal on_ As Control, ByVal off_ As Control)
        If togMusic = True Then
            Try
                My.Computer.Audio.Play(startpath & "/bgmusic/bgmenu.wav", AudioPlayMode.BackgroundLoop)
            Catch
            End Try

            on_.Visible = True

            off_.Visible = False
        Else
            My.Computer.Audio.Stop()

            on_.Visible = False
            off_.Visible = True
        End If
    End Sub
    Sub BGMStage(ByVal on_ As Control, ByVal off_ As Control)
        If togMusic = True Then
            Try
                My.Computer.Audio.Play(startpath & "/bgmusic/bgstage.wav", AudioPlayMode.BackgroundLoop)
            Catch
            End Try

            on_.Visible = True

            off_.Visible = False
        Else
            My.Computer.Audio.Stop()

            on_.Visible = False
            off_.Visible = True
        End If
    End Sub
    Sub BGMLevel2()
        If togMusic = True Then
            My.Computer.Audio.Play(startpath & "/bgmusic/bglevel2.wav", AudioPlayMode.BackgroundLoop)
        End If
    End Sub
    Sub BGMLevel3()
        If togmusic = True Then
            My.Computer.Audio.Play(startpath & "/bgmusic/bglevel3.wav", AudioPlayMode.BackgroundLoop)
        End If
    End Sub
    Sub BGM2Player()
        If togmusic = True Then
            My.Computer.Audio.Play(startpath & "/bgmusic/bg2player.wav", AudioPlayMode.BackgroundLoop)
        End If
    End Sub
    Public Sub BGStage1()
        If togmusic = True Then
            My.Computer.Audio.Play(startpath & "/bgmusic/bgstage1.wav", AudioPlayMode.BackgroundLoop)
        End If
    End Sub
    Public Sub BGMusic()
        If togmusic = True Then
            My.Computer.Audio.Play(startpath & "/bgmusic/bgmenu.wav", AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub
    Sub BGMStop()
        My.Computer.Audio.Stop()
    End Sub
End Module
