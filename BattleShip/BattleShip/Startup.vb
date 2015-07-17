Public Class Startup
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'Exits the app
        End
    End Sub
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        'Starts a game
        Me.Hide()
        p1board.Show()
    End Sub
    Private Sub btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        'About the game
        MessageBox.Show("NavalQuest is a nautical strategy game made by Ryan Hecht" & vbNewLine &
                        "based on the board game Battleship by Milton Bradley. Made" & vbNewLine &
                        "in May of 2013 as Ryan's final Visual Basic class project," & vbNewLine &
                        "the game represents the manifestation of the skills he has" & vbNewLine &
                        "learned in the language over the year. Ryan is excited to" & vbNewLine &
                        "broaden his coding horizons and start new projects in the" & vbNewLine &
                        "months to come. Follow him on Twitter @Ryan_Hecht and check" & vbNewLine &
                        "his Mediafire page for the latest on new projects. Enjoy" & vbNewLine &
                        "NavalQuest, the classic game of nautical strategy.", "About", MessageBoxButtons.OK)
    End Sub
End Class