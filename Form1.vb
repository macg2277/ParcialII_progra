Imports System.Data.SqlClient

Public Class Form1
    Dim conexion As New SqlConnection("Server=DESKTOP-EG6N7VP\SQLEXPRESS; Database=BDParcial2ManuelYLuis; Integrated Security=true")
    Dim conexion2 As New SqlConnection("Server=DESKTOP-EG6N7VP\SQLEXPRESS; Database=BDParcial2ManuelYLuis; user Id=sa ; Password=Anthony-2379")

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim comando As New SqlCommand("Insert Into Cliente (Nombre,Apellido,Departamento,Municipio) 
                                      Values('" & txtNombre.Text.Trim & "','" & txtApellido.Text.Trim & "','" & Me.cbDepartamento.SelectedValue & "','" & Me.cbMunicipio.SelectedValue & "')", conexion2)
            conexion2.Open()
            comando.ExecuteNonQuery()
            MsgBox("Guardado, creado Por Manuel & Luis")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion2.Close()
            MsgBox("Se Cerro la conexión")
            txtNombre.Text = ""
            txtApellido.Text = ""
            cbDepartamento.Text = "Seleccione..."
            cbMunicipio.Text = "Seleccione..."
        End Try

    End Sub
    Sub CargarDepartamento()
        Try
            Dim consulta = "Select *from Departamento"
            Dim da As New SqlDataAdapter(consulta, conexion2)
            Dim ds As New DataSet
            da.Fill(ds, "Departamento")
            Me.cbDepartamento.DataSource = ds.Tables("Departamento")
            Me.cbDepartamento.DisplayMember = "N_Departamento"
            Me.cbDepartamento.ValueMember = "IdDepartamento"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub cargarMunicipio()
        Try
            Dim consulta = "Select *from Municipio"
            Dim da As New SqlDataAdapter(consulta, conexion2)
            Dim ds As New DataSet
            da.Fill(ds, "Municipio")
            Me.cbMunicipio.DataSource = ds.Tables("Municipio")
            Me.cbMunicipio.DisplayMember = "Municipio"
            Me.cbMunicipio.ValueMember = "IdMunicipio"
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDepartamento()
        cargarMunicipio()

    End Sub
End Class
'Estudiantes: 
'Manuel Antonio Cruz Garcia 
'Luis enrique lopez Alvarado
