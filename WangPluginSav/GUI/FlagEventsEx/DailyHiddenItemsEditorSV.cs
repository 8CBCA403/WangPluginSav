using System.Text;

namespace WangPluginSav.Util.EventFlags
{
    public partial class DailyHiddenItemsEditorSV : Form
    {
        readonly FlagsGen9SV m_organizer;
        readonly Dictionary<ulong, byte[]> m_blocks;
        readonly Dictionary<ulong, byte[]> m_editableBlocks;

        readonly Dictionary<int, ulong> m_indexToKeys;
        int m_curSelectedBlockIdx;
        bool isSyncingCells;

        readonly Dictionary<byte, string> m_itemsIndexesList = new Dictionary<byte, string>()
        {
            { 0x00, "- 收集 -" },
            { 0x01, "道具 (0x01)" },
            { 0x02, "道具 (0x02)" },
            { 0x03, "道具 (0x03)" },
            { 0x04, "道具 (0x04)" },
            { 0x05, "道具 (0x05)" },
            { 0x06, "道具 (0x06)" },
            { 0x07, "道具 (0x07)" },
            { 0x08, "道具 (0x08)" },
            { 0x09, "道具 (0x09)" },
            { 0x0A, "道具 (0x0A)" },
            { 0x0B, "道具 (0x0B)" },
            { 0x0C, "道具 (0x0C)" },
            { 0x0D, "道具 (0x0D)" },
            { 0x0E, "道具 (0x0E)" },
            { 0x0F, "道具 (0x0F)" },
            { 0x10, "道具 (0x10)" },
            { 0x11, "道具 (0x11)" },
            { 0x12, "道具 (0x12)" },
            { 0x13, "道具 (0x13)" },
            { 0x14, "道具 (0x14)" },
            { 0x15, "道具 (0x15)" },
            { 0x16, "道具 (0x16)" },
            { 0x17, "道具 (0x17)" },
            { 0x18, "道具 (0x18)" },
            { 0x19, "道具 (0x19)" },
            { 0x1A, "道具 (0x1A)" },
            { 0x1B, "道具 (0x1B)" },
            { 0x1C, "道具 (0x1C)" },
            { 0x1D, "道具 (0x1D)" },
            { 0x1E, "道具 (0x1E)" },
            { 0x1F, "道具 (0x1F)" },
            { 0x20, "道具 (0x20)" },
            { 0x21, "道具 (0x21)" },
            { 0x22, "道具 (0x22)" },
            { 0x23, "道具 (0x23)" },
            { 0x24, "道具 (0x24)" },
            { 0x25, "道具 (0x25)" },
            { 0x26, "道具 (0x26)" },
            { 0x27, "道具 (0x27)" },
            { 0x28, "道具 (0x28)" },
            { 0x29, "道具 (0x29)" },
            { 0x2A, "道具 (0x2A)" },
            { 0x2B, "道具 (0x2B)" },
            { 0x2C, "道具 (0x2C)" },
            { 0x2D, "道具 (0x2D)" },
            { 0x2E, "道具 (0x2E)" },
            { 0x2F, "道具 (0x2F)" },
            { 0x30, "道具 (0x30)" },
            { 0x31, "道具 (0x31)" },
            { 0x32, "道具 (0x32)" },
            { 0x33, "道具 (0x33)" },
            { 0x34, "道具 (0x34)" },
            { 0x35, "道具 (0x35)" },
            { 0x36, "道具 (0x36)" },
            { 0x37, "道具 (0x37)" },
            { 0x38, "道具 (0x38)" },
            { 0x39, "道具 (0x39)" },
            { 0x3A, "道具 (0x3A)" },
            { 0x3B, "道具 (0x3B)" },
            { 0x3C, "道具 (0x3C)" },
            { 0x3D, "道具 (0x3D)" },
            { 0x3E, "道具 (0x3E)" },
            { 0x3F, "道具 (0x3F)" },
            { 0x40, "道具 (0x40)" },
            { 0x41, "道具 (0x41)" },
            { 0x42, "道具 (0x42)" },
            { 0x43, "道具 (0x43)" },
            { 0x44, "道具 (0x44)" },
            { 0x45, "道具 (0x45)" },
            { 0x46, "道具 (0x46)" },
            { 0x47, "道具 (0x47)" },
            { 0x48, "道具 (0x48)" },
            { 0x49, "道具 (0x49)" },
            { 0x4A, "道具 (0x4A)" },
            { 0x4B, "道具 (0x4B)" },
            { 0x4C, "道具 (0x4C)" },
            { 0x4D, "道具 (0x4D)" },
            { 0x4E, "道具 (0x4E)" },
            { 0x4F, "道具 (0x4F)" },
            { 0x50, "道具 (0x50)" },
            { 0x51, "道具 (0x51)" },
            { 0x52, "道具 (0x52)" },
            { 0x53, "道具 (0x53)" },
            { 0x54, "道具 (0x54)" },
            { 0x55, "道具 (0x55)" },
            { 0x56, "道具 (0x56)" },
            { 0x57, "道具 (0x57)" },
            { 0x58, "道具 (0x58)" },
            { 0x59, "道具 (0x59)" },
            { 0x5A, "道具 (0x5A)" },
            { 0x5B, "道具 (0x5B)" },
            { 0x5C, "道具 (0x5C)" },
            { 0x5D, "道具 (0x5D)" },
            { 0x5E, "道具 (0x5E)" },
            { 0x5F, "道具 (0x5F)" },
            { 0x60, "道具 (0x60)" },
            { 0x61, "道具 (0x61)" },
            { 0x62, "道具 (0x62)" },
            { 0x63, "道具 (0x63)" },
            { 0x64, "道具 (0x64)" },
            { 0x65, "道具 (0x65)" },
            { 0x66, "道具 (0x66)" },
            { 0x67, "道具 (0x67)" },
            { 0x68, "道具 (0x68)" },
            { 0x69, "道具 (0x69)" },
            { 0x6A, "道具 (0x6A)" },
            { 0x6B, "道具 (0x6B)" },
            { 0x6C, "道具 (0x6C)" },
            { 0x6D, "道具 (0x6D)" },
            { 0x6E, "道具 (0x6E)" },
            { 0x6F, "道具 (0x6F)" },
            { 0x70, "道具 (0x70)" },
            { 0x71, "道具 (0x71)" },
            { 0x72, "道具 (0x72)" },
            { 0x73, "道具 (0x73)" },
            { 0x74, "道具 (0x74)" },
            { 0x75, "道具 (0x75)" },
            { 0x76, "道具 (0x76)" },
            { 0x77, "道具 (0x77)" },
            { 0x78, "道具 (0x78)" },
            { 0x79, "道具 (0x79)" },
            { 0x7A, "道具 (0x7A)" },
            { 0x7B, "道具 (0x7B)" },
            { 0x7C, "道具 (0x7C)" },
            { 0x7D, "道具 (0x7D)" },
            { 0x7E, "道具 (0x7E)" },
            { 0x7F, "道具 (0x7F)" },
            { 0x80, "- 空 (0x80) -" },
            { 0x81, "- 空 (0x81) -" },
            { 0x82, "- 空 (0x82) -" },
            { 0x83, "- 空 (0x83) -" },
            { 0x84, "- 空 (0x84) -" },
            { 0x85, "- 空 (0x85) -" },
            { 0x86, "- 空 (0x86) -" },
            { 0x87, "- 空 (0x87) -" },
            { 0x88, "- 空 (0x88) -" },
            { 0x89, "- 空 (0x89) -" },
            { 0x8A, "- 空 (0x8A) -" },
            { 0x8B, "- 空 (0x8B) -" },
            { 0x8C, "- 空 (0x8C) -" },
            { 0x8D, "- 空 (0x8D) -" },
            { 0x8E, "- 空 (0x8E) -" },
            { 0x8F, "- 空 (0x8F) -" },
            { 0x90, "- 空 (0x90) -" },
            { 0x91, "- 空 (0x91) -" },
            { 0x92, "- 空 (0x92) -" },
            { 0x93, "- 空 (0x93) -" },
            { 0x94, "- 空 (0x94) -" },
            { 0x95, "- 空 (0x95) -" },
            { 0x96, "- 空 (0x96) -" },
            { 0x97, "- 空 (0x97) -" },
            { 0x98, "- 空 (0x98) -" },
            { 0x99, "- 空 (0x99) -" },
            { 0x9A, "- 空 (0x9A) -" },
            { 0x9B, "- 空 (0x9B) -" },
            { 0x9C, "- 空 (0x9C) -" },
            { 0x9D, "- 空 (0x9D) -" },
            { 0x9E, "- 空 (0x9E) -" },
            { 0x9F, "- 空 (0x9F) -" },
            { 0xA0, "- 空 (0xA0) -" },
            { 0xA1, "- 空 (0xA1) -" },
            { 0xA2, "- 空 (0xA2) -" },
            { 0xA3, "- 空 (0xA3) -" },
            { 0xA4, "- 空 (0xA4) -" },
            { 0xA5, "- 空 (0xA5) -" },
            { 0xA6, "- 空 (0xA6) -" },
            { 0xA7, "- 空 (0xA7) -" },
            { 0xA8, "- 空 (0xA8) -" },
            { 0xA9, "- 空 (0xA9) -" },
            { 0xAA, "- 空 (0xAA) -" },
            { 0xAB, "- 空 (0xAB) -" },
            { 0xAC, "- 空 (0xAC) -" },
            { 0xAD, "- 空 (0xAD) -" },
            { 0xAE, "- 空 (0xAE) -" },
            { 0xAF, "- 空 (0xAF) -" },
            { 0xB0, "- 空 (0xB0) -" },
            { 0xB1, "- 空 (0xB1) -" },
            { 0xB2, "- 空 (0xB2) -" },
            { 0xB3, "- 空 (0xB3) -" },
            { 0xB4, "- 空 (0xB4) -" },
            { 0xB5, "- 空 (0xB5) -" },
            { 0xB6, "- 空 (0xB6) -" },
            { 0xB7, "- 空 (0xB7) -" },
            { 0xB8, "- 空 (0xB8) -" },
            { 0xB9, "- 空 (0xB9) -" },
            { 0xBA, "- 空 (0xBA) -" },
            { 0xBB, "- 空 (0xBB) -" },
            { 0xBC, "- 空 (0xBC) -" },
            { 0xBD, "- 空 (0xBD) -" },
            { 0xBE, "- 空 (0xBE) -" },
            { 0xBF, "- 空 (0xBF) -" },
            { 0xC0, "- 空 (0xC0) -" },
            { 0xC1, "- 空 (0xC1) -" },
            { 0xC2, "- 空 (0xC2) -" },
            { 0xC3, "- 空 (0xC3) -" },
            { 0xC4, "- 空 (0xC4) -" },
            { 0xC5, "- 空 (0xC5) -" },
            { 0xC6, "- 空 (0xC6) -" },
            { 0xC7, "- 空 (0xC7) -" },
            { 0xC8, "- 空 (0xC8) -" },
            { 0xC9, "- 空 (0xC9) -" },
            { 0xCA, "- 空 (0xCA) -" },
            { 0xCB, "- 空 (0xCB) -" },
            { 0xCC, "- 空 (0xCC) -" },
            { 0xCD, "- 空 (0xCD) -" },
            { 0xCE, "- 空 (0xCE) -" },
            { 0xCF, "- 空 (0xCF) -" },
            { 0xD0, "- 空 (0xD0) -" },
            { 0xD1, "- 空 (0xD1) -" },
            { 0xD2, "- 空 (0xD2) -" },
            { 0xD3, "- 空 (0xD3) -" },
            { 0xD4, "- 空 (0xD4) -" },
            { 0xD5, "- 空 (0xD5) -" },
            { 0xD6, "- 空 (0xD6) -" },
            { 0xD7, "- 空 (0xD7) -" },
            { 0xD8, "- 空 (0xD8) -" },
            { 0xD9, "- 空 (0xD9) -" },
            { 0xDA, "- 空 (0xDA) -" },
            { 0xDB, "- 空 (0xDB) -" },
            { 0xDC, "- 空 (0xDC) -" },
            { 0xDD, "- 空 (0xDD) -" },
            { 0xDE, "- 空 (0xDE) -" },
            { 0xDF, "- 空 (0xDF) -" },
            { 0xE0, "- 空 (0xE0) -" },
            { 0xE1, "- 空 (0xE1) -" },
            { 0xE2, "- 空 (0xE2) -" },
            { 0xE3, "- 空 (0xE3) -" },
            { 0xE4, "- 空 (0xE4) -" },
            { 0xE5, "- 空 (0xE5) -" },
            { 0xE6, "- 空 (0xE6) -" },
            { 0xE7, "- 空 (0xE7) -" },
            { 0xE8, "- 空 (0xE8) -" },
            { 0xE9, "- 空 (0xE9) -" },
            { 0xEA, "- 空 (0xEA) -" },
            { 0xEB, "- 空 (0xEB) -" },
            { 0xEC, "- 空 (0xEC) -" },
            { 0xED, "- 空 (0xED) -" },
            { 0xEE, "- 空 (0xEE) -" },
            { 0xEF, "- 空 (0xEF) -" },
            { 0xF0, "- 空 (0xF0) -" },
            { 0xF1, "- 空 (0xF1) -" },
            { 0xF2, "- 空 (0xF2) -" },
            { 0xF3, "- 空 (0xF3) -" },
            { 0xF4, "- 空 (0xF4) -" },
            { 0xF5, "- 空 (0xF5) -" },
            { 0xF6, "- 空 (0xF6) -" },
            { 0xF7, "- 空 (0xF7) -" },
            { 0xF8, "- 空 (0xF8) -" },
            { 0xF9, "- 空 (0xF9) -" },
            { 0xFA, "- 空 (0xFA) -" },
            { 0xFB, "- 空 (0xFB) -" },
            { 0xFC, "- 空 (0xFC) -" },
            { 0xFD, "- 空 (0xFD) -" },
            { 0xFE, "- 空 (0xFE) -" },
            { 0xFF, "- 空 (0xFF) -" },
        };


        public DailyHiddenItemsEditorSV(FlagsOrganizer flagsOrganizer)
        {
            m_organizer = (FlagsGen9SV)flagsOrganizer;
            m_blocks = m_organizer.GetHiddenItemBlocksCopy();

            InitializeComponent();
            LocalizedStrings.LocalizeForm(this);

            m_indexToKeys = new Dictionary<int, ulong>(20);
            m_editableBlocks = new Dictionary<ulong, byte[]>(20);
            foreach (var block in m_blocks)
            {
                m_editableBlocks[block.Key] = new byte[block.Value.Length];
                blockSourceCombo.Items.Add(block.Key switch
                {
                    // Paldea
                    0x6DAB304B => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockPaldeaSouth", "South Paldea areas"),
                    0x6EAB31DE => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockPaldeaWest", "West Paldea areas"),
                    0x6FAB3371 => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockPaldeaNorth", "North Paldea areas"),
                    0x6CAB2EB8 => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockPaldeaEast", "East Paldea areas"),

                    // Area Zero
                    0x9A7A41AB => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockAreaZero1", "Area Zero 1"),
                    0x9B7A433E => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockAreaZero2", "Area Zero 2"),
                    0x9C7A44D1 => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockAreaZero3", "Area Zero 3"),

                    // DLC1
                    0x917A3380 => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockDlC1_1", "Kitakami 1"),
                    0xA07A4B1D => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockDLC1_2", "Kitakami 2"),

                    // DLC2
                    0x1281BA58 => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockDlC2_1", "Terarium 1"),
                    0x1381BBEB => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockDlC2_2", "Terarium 2"),
                    0x257F99AA => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockDlC2_3", "Terarium 3"),

                    0x1E7F8EA5 => LocalizedStrings.Find("DailyHiddenItemsEditorSV.blockDlC2_AreaZeroDepths", "Area Zero Depths"),

                    _ => $"??? {block.Key}"
                });
                m_indexToKeys[blockSourceCombo.Items.Count - 1] = block.Key;
            }

            m_curSelectedBlockIdx = 0;
            blockSourceCombo.SelectedIndex = 0;
            itemIIndexSelectionCombo.Items.AddRange(m_itemsIndexesList.Values.ToArray());
            itemIIndexSelectionCombo.SelectedIndex = 0;

            dataGridView.CurrentCellDirtyStateChanged += DataGridView_CurrentCellDirtyStateChanged;
            dataGridView.CellValueChanged += DataGridView_CellValueChanged;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

#if DEBUG
            this.KeyPreview = true;
            this.KeyDown += (object? sender, KeyEventArgs e) =>
            {
                if (e.KeyCode == Keys.D)
                {
                    StringBuilder sb = new StringBuilder(512 * 1024);
                    foreach (var tBlock in m_blocks)
                    {
                        sb.Append($"0x{tBlock.Key:X16}\r\n");

                        for (int i = 1; i < tBlock.Value.Length; i++)
                        {
                            sb.Append($"{i:D04} => 0x{tBlock.Value[i - 1]:X02}\r\n");
                        }

                        sb.Append("\r\n\r\n");
                    }

                    System.IO.File.WriteAllText("_hiddenItemsList.txt", sb.ToString());
                }
            };
#endif

            RestoreData();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            m_organizer.SyncEditedHiddenItems(m_editableBlocks);
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e) => Close();

        private void SetAllBtn_Click(object sender, EventArgs e)
        {
            byte itemId = m_itemsIndexesList.First(x => x.Value == (string)itemIIndexSelectionCombo.SelectedItem!).Key;

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                var cells = dataGridView.Rows[i].Cells;
                var idx = ((uint?)(cells[0].Value)).Value;

                m_editableBlocks[m_indexToKeys[m_curSelectedBlockIdx]][idx - 1] = itemId;
            }

            RefreshDataGrid();
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            RestoreData();
        }

        private void BlockSourceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_curSelectedBlockIdx != blockSourceCombo.SelectedIndex)
            {
                m_curSelectedBlockIdx = blockSourceCombo.SelectedIndex;
                RefreshDataGrid();
            }
        }

        private void FilterByItemChk_CheckedChanged(object sender, EventArgs e) => RefreshDataGrid();

        private void ItemIIndexSelectionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterByItemChk.Checked)
            {
                RefreshDataGrid();
            }
        }

        private void DataGridView_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (dataGridView.IsCurrentCellDirty)
            {
                dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridView_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (!isSyncingCells)
            {
                var cells = dataGridView.Rows[e.RowIndex].Cells;
                var idx = ((uint?)(cells[0].Value)).Value;
                var strVal = (string)cells[2].Value;
                byte data = m_itemsIndexesList.First(x => x.Value == strVal).Key;
                m_editableBlocks[m_indexToKeys[m_curSelectedBlockIdx]][idx - 1] = data;
            }
        }



        private void RestoreData()
        {
            foreach (var block in m_blocks)
            {
                Array.Copy(block.Value, m_editableBlocks[block.Key], block.Value.Length);
            }

            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            if (!isSyncingCells)
            {
                isSyncingCells = true;
                this.SuspendLayout();

                bool filterByItem = filterByItemChk.Checked;
                byte filteredItemId = m_itemsIndexesList.First(x => x.Value == (string)itemIIndexSelectionCombo.SelectedItem!).Key;
                uint refNum = 1;

                List<DataGridViewRow> rowsToAdd = [];

                foreach (var data in m_editableBlocks[m_indexToKeys[m_curSelectedBlockIdx]])
                {
                    if (filterByItem && data != filteredItemId)
                    {
                        refNum++;
                        continue;
                    }

                    var curRow = new DataGridViewRow();
                    curRow.CreateCells(dataGridView);
                    curRow.Cells[0].Value = refNum++;
                    curRow.Cells[1].Value = string.Empty;
                    curRow.Cells[2] = new DataGridViewComboBoxCell() { DataSource = m_itemsIndexesList.Values.ToList(), Value = m_itemsIndexesList[data] };

                    rowsToAdd.Add(curRow);
                }

                dataGridView.Rows.Clear();
                dataGridView.Refresh();

                dataGridView.Rows.AddRange([.. rowsToAdd]);

                isSyncingCells = false;
                this.ResumeLayout(false);
            }
        }

    }
}
