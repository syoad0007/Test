Public Class WebForm1
    Inherits System.Web.UI.Page


    Private Class TVData


        Public Property Id() As String
        Public Property Name() As String
        Public Property Data() As String
        Public Property リンク() As String
        Public Property NodeText() As String
        Public Property データ() As String
        Public Property ParentNode() As String

    End Class


    Private Class GVData

        Public Property Name() As String
        Public Property Data() As String

        Public Sub New()
        End Sub

        Public Sub New(a_Namne As String, a_Data As String)
            Name = a_Namne
            Data = a_Data
        End Sub


    End Class

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack Then
            Return
        End If

        '初期データ生成
        Dim sampleData = CreateData()

        Me.CreateNode_Top("Top", TreeView1.Nodes, sampleData)



        GridView1.DataSource = Nothing
        GridView1.DataBind()

        Dim noList As New List(Of GVData)
        'noList.Add(New GVData("OK", "NG"))
        'noList.Add(New GVData())
        GridView2.DataSource = noList
        GridView2.DataBind()
        If GridView2.Rows.Count = 0 Then
            GridView2.GridLines = GridLines.None
        Else
            GridView2.GridLines = GridLines.Both
        End If

        Return

    End Sub


    Sub Select_Change(ByVal sender As Object, ByVal e As EventArgs)

        Dim myText As String = TreeView1.SelectedNode.Text
        Dim myValue As String = TreeView1.SelectedNode.Value
        Dim myURL As String = TreeView1.SelectedNode.NavigateUrl

        Dim cScript = "alert('テキスト：" + myText +
            " \nバリュー：" + myValue +
            " \URL：" + myURL + "');"

        'ClientScript.RegisterClientScriptBlock(Me.GetType(), "key", cScript, True)

        'GridViewにデータを設定
        SetGridView()

        '選択個所の色を変更
        Dim ss = TreeView1.SelectedNodeStyle
        ss.CssClass = "ChangeRow"

    End Sub



    Private Sub CreateNode_Top(parent As String, nodes As TreeNodeCollection, sampleData As List(Of TVData))

        '取得したコンテンツを新規ノードとして現在ノードの配下に追加
        For Each row As TVData In sampleData.Where(Function(x) x.ParentNode = parent)
            Dim node As New TreeNode()

            'リンク先を指定すると、Select_Changeイベントが発生しないため使用不可
            'node.NavigateUrl = row.リンク   'リンク先

            node.Text = row.NodeText        'ノード・テキスト
            node.Value = row.ParentNode       'ノード値
            'node.PopulateOnDemand = True ' オンデマンドで子ノードを取得するか
            Me.CreateNode(row.データ, node.ChildNodes, sampleData)
            nodes.Add(node)
        Next

    End Sub




    Private Sub CreateNode(parent As String, nodes As TreeNodeCollection, sampleData As List(Of TVData))

        '取得したコンテンツを新規ノードとして現在ノードの配下に追加
        For Each row As TVData In sampleData.Where(Function(x) x.ParentNode = parent)
            Dim node As New TreeNode()
            'node.NavigateUrl = row.リンク  'リンク先
            node.Text = row.NodeText        'ノード・テキスト
            node.Value = row.ParentNode       'ノード値

            node.SelectAction = TreeNodeSelectAction.Select

            Me.CreateNode(row.ParentNode + "\" + row.データ, node.ChildNodes, sampleData)
            nodes.Add(node)
        Next

    End Sub


    Private Function CreateData() As List(Of TVData)

        Dim retval As New List(Of TVData)

        'トップノードの生成
        For icounter As Integer = 0 To 3
            Dim data As New TVData
            data.Id = "ID" + icounter.ToString
            data.Name = "Name" + icounter.ToString
            data.Data = "Data" + icounter.ToString
            data.リンク = "リンク" + icounter.ToString
            data.NodeText = "テキスト" + icounter.ToString
            data.データ = "データ" + icounter.ToString
            data.ParentNode = "Top"

            retval.Add(data)
        Next

        '第２ノードの生成(データ1に紐づくデータ)
        For icounter As Integer = 0 To 5
            Dim data As New TVData
            data.Id = "ID2_" + icounter.ToString
            data.Name = "Name2_" + icounter.ToString
            data.Data = "Data2_" + icounter.ToString
            data.リンク = "リンク2_" + icounter.ToString
            data.NodeText = "テキスト2_" + icounter.ToString
            data.データ = "データ2_" + icounter.ToString
            data.ParentNode = "データ1"
            retval.Add(data)
        Next

        '第３ノードの生成(データ2_1に紐づくデータ)
        For icounter As Integer = 0 To 5
            Dim data As New TVData
            data.Id = "ID3_" + icounter.ToString
            data.Name = "Name3_" + icounter.ToString
            data.Data = "Data3_" + icounter.ToString
            data.リンク = "リンク3_" + icounter.ToString
            data.NodeText = "テキスト3_" + icounter.ToString
            data.データ = "データ3_" + icounter.ToString
            data.ParentNode = "データ1\データ2_1"
            retval.Add(data)
        Next


        Return retval

    End Function



    Private Sub SetGridView()

        Dim gvList As New List(Of GVData)

        For icounter As Integer = 0 To 5
            Dim dv As New GVData
            dv.Name = "表示データ" + icounter.ToString
            dv.Data = "非表示データ" + icounter.ToString
            gvList.Add(dv)
        Next
        GridView1.DataSource = gvList

        'GridView1.Columns(1).Visible = True
        GridView1.DataBind()
        'GridView1.Columns(1).Visible = False

        Return

    End Sub

End Class
