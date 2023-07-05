Imports System.IO

Public Class mainForm
    'Amount of souls needed to get from Soul Level 1 to Soul Level 11; the formula that is being used does not accurately output souls needed for these levels
    Public Shared ReadOnly a() As UInteger = {673, 689, 706, 723, 740, 757, 775, 793, 811, 829}

    Sub Main()
        'do something
    End Sub

    ''' <summary>
    ''' Calculates the number of souls needed to go from current level to target level.
    ''' </summary>
    ''' <param name="sender">object that raised the event</param>
    ''' <param name="e">EventArgs passed to method</param>
    Private Sub SoulsNeeded_TextChanged(sender As Object, e As EventArgs) Handles initialLvlSNUpDown.TextChanged, targetLvlSNUpDown.TextChanged

        'check that TextBoxes for initial level and target level do not contain empty strings or are not null; exit sub if either TextBox contains a null value or empty string
        If String.IsNullOrEmpty(initialLvlSNUpDown.Text) OrElse
            String.IsNullOrEmpty(targetLvlSNUpDown.Text) Then Exit Sub

        'check that TextBoxes for initial level and target level contain numbers; exit sub if either TextBox contains non-numeric values
        If Not IsNumeric(initialLvlSNUpDown.Text) OrElse
            Not IsNumeric(targetLvlSNUpDown.Text) Then Exit Sub

        Dim iLvl As ULong = CULng(initialLvlSNUpDown.Text)  'initial level value entered by user
        Dim tLvl As ULong = CULng(targetLvlSNUpDown.Text)   'target level value entered by user
        Dim y As Decimal = 0                                'variable used to calculate souls needed to level-up once
        Dim soulsNeeded As ULong = 0                        'variable for calculated souls needed to level up from initial level to target level

        If iLvl - 1 < 0 Then    'might change to '< 1'
            Exit Sub
        End If

        'calculate souls needed to get from initial level to target level
        Do While iLvl < tLvl

            If iLvl < 11 Then
                'if initial level is below 11, get value of souls needed for level-up from array
                y += a(iLvl - 1)
            Else
                'calculate souls needed to level-up once based on initial level
                y += (0.02 * ((iLvl + 1) ^ 3)) + (3.06 * ((iLvl + 1) ^ 2)) + (105.6 * (iLvl + 1)) - 895
            End If

            'increment initial level by one to continue calculations
            iLvl += 1
        Loop

        'get absolute value for souls needed to level up
        soulsNeeded = Math.Abs(y)

        'set Text property for soulsNeededTextBox TextBox
        soulsNeededTextBox.Text = soulsNeeded

    End Sub

    ''' <summary>
    ''' Calculates total possible level-ups based on characters current level and current souls.
    ''' </summary>
    ''' <param name="sender">object that raised the event</param>
    ''' <param name="e">EventArgs passed to method</param>
    Private Sub LevelUps_TextChanged(sender As Object, e As EventArgs) Handles currentLvlLAUpDown.TextChanged, currentSoulsLAUpDown.TextChanged

        'check that TextBoxes for current level and current souls do not contain empty strings or are not null; exit sub if either TextBox contains a null value or empty string
        If String.IsNullOrEmpty(currentLvlLAUpDown.Text) OrElse
            String.IsNullOrEmpty(currentSoulsLAUpDown.Text) Then Exit Sub

        'check that TextBoxes for current level and current souls contain numbers; exit sub if either TextBox contains non-numeric values
        If Not IsNumeric(currentLvlLAUpDown.Text) OrElse
            Not IsNumeric(currentSoulsLAUpDown.Text) Then Exit Sub

        Dim levelsAvailable As Integer = 0                      'variable for calculated total possible level-ups
        Dim lvlIncrement As Integer                             'used in place of cLevel during calculation
        Dim y As Decimal = 0                                    'variable to calculate souls needed to level-up once
        Dim soulsNeeded As ULong = 0                            'variable for calculated possible level-ups
        Dim cLevel As ULong = CULng(currentLvlLAUpDown.Text)    'current level value entered by user
        Dim cSouls As ULong = CULng(currentSoulsLAUpDown.Text)  'current souls value entered by user

        If cLevel - 1 < 0 Then  'might change to '< 1'
            Exit Sub
        End If

        lvlIncrement = cLevel

        'calculate total possible level-ups from current level using current souls amount
        Do While soulsNeeded <= cSouls 'cSouls >= soulsNeeded

            If lvlIncrement < 11 Then
                'if current level is less than 11, get value of souls needed for level-up from array
                y = a(lvlIncrement - 1)
            Else
                'calculate souls needed to level-up once based on initial level
                y = (0.02 * ((lvlIncrement + 1) ^ 3)) + (3.06 * ((lvlIncrement + 1) ^ 2)) + (105.6 * (lvlIncrement + 1)) - 895
            End If

            soulsNeeded += Math.Abs(y)  'increment total souls needed by amount calculated

            levelsAvailable += 1    'increment level-ups available by 1
            lvlIncrement += 1       'increment current level by 1

        Loop

        'display results of calculation
        If cLevel = 802 Then
            levelsAvailableTextBox.Text = "Already at Max Level"
        End If

        If cLevel + levelsAvailable > 802 Then
            levelsAvailableTextBox.Text = 802 - cLevel
        Else
            levelsAvailableTextBox.Text = levelsAvailable - 1
        End If

    End Sub

    ''' <summary>
    ''' Resets Text property values for TextBoxes on Form to initial values.
    ''' </summary>
    ''' <param name="sender">object that raised the event</param>
    ''' <param name="e">EventArgs passed to method</param>
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        'set Text property value for input TextBoxes on Form to initial values
        initialLvlSNUpDown.Text = 1
        targetLvlSNUpDown.Text = 1
        currentLvlLAUpDown.Text = 1
        currentSoulsLAUpDown.Text = 0

    End Sub

    ''' <summary>
    ''' Saves values for initial level, target level, current level, current souls from corresponding TextBoxes on Form to a text file.
    ''' </summary>
    ''' <param name="sender">object that raised the event</param>
    ''' <param name="e">EventArgs passed to method</param>
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        Dim writer As StreamWriter                                  'StreamWriter object to write data to file
        Dim result As DialogResult                                  'DialogResult result object for event raised from SaveFileDialog
        Dim fileName, fileData As String                            'variables for the name of file to save data to and data to save to file, respectively

        'data to write to file
        fileData = initialLvlSNUpDown.Text & "," & targetLvlSNUpDown.Text & "," & currentLvlLAUpDown.Text & "," & currentSoulsLAUpDown.Text

        'display SaveFileDialog window for user to choose where to save file and with what name, save DialogResult
        Using fileChooser As New SaveFileDialog()

            fileChooser.Filter = "TXT Files (*.txt*)|*.txt" 'file extensions for user to choose from
            result = fileChooser.ShowDialog()               'DialogResult from SaveFileDialog window
            fileName = fileChooser.FileName                 'file name entered by user

        End Using

        'write date to file if user did not click Cancel button on SaveFileDialog window
        If result <> Windows.Forms.DialogResult.Cancel Then

            writer = New StreamWriter(fileName) 'creates new file and opens stream to write data to file if file does not exist, overwrites file if file does exist

            'write data to file
            writer.Write(fileData)

            writer.Close()  'close StreamWriter stream

        End If

    End Sub

    ''' <summary>
    ''' Opens text file that contains values for initial level, target level, current level, and current souls for corresponding TextBoxes on Form.
    ''' </summary>
    ''' <param name="sender">object that raised the event</param>
    ''' <param name="e">EventArgs passed to method</param>
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        Dim reader As StreamReader      'StreamReader object to read data from file
        Dim result As DialogResult      'DialogResult object for event raised from OpenFileDialog
        Dim fileName As String          'variable for the name of the file to open

        'display OpenFileDialog window for user to choose which file to open
        Using fileChooser As New OpenFileDialog()

            result = fileChooser.ShowDialog()   'DialogResult from OpenFileDialog window
            fileName = fileChooser.FileName     'file name entered by user

        End Using

        'read from file if user did not click Cancel button on OpenFileDialog window
        If result <> Windows.Forms.DialogResult.Cancel Then

            reader = New StreamReader(fileName) 'creates stream to read data from file

            Dim fileData As String = reader.ReadLine()      'read data from file
            Dim fields() As String = fileData.Split(","c)   'split data in variable by comma value separator

            'set Text property values for TextBoxes on Form
            initialLvlSNUpDown.Text = fields(0)
            targetLvlSNUpDown.Text = fields(1)
            currentLvlLAUpDown.Text = fields(2)
            currentSoulsLAUpDown.Text = fields(3)

            reader.Close()  'close StreamReader stream

        End If

    End Sub

    ''' <summary>
    ''' Method that closes the current Form.
    ''' </summary>
    ''' <param name="sender">object that raised the event</param>
    ''' <param name="e">EventArgs passed to method</param>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()  'closes Form, which terminates application

    End Sub

End Class