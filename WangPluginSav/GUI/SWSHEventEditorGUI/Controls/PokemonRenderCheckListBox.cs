﻿using System.Collections.ObjectModel;

namespace WangPluginSav.GUI.SWSHEventEditorGUI.Controls
{
    public partial class PokemonRenderCheckListBox : UserControl
    {
        public PokemonRenderCheckListBox()
        {
            InitializeComponent();
        }

        private bool _containsMouse = false;
        private Point _relativeMousePosition = Point.Empty;
        private ObservableCollection<int> _pokemonArray = new ObservableCollection<int>();


        public ObservableCollection<int> PokemonIDs
        {
            get => this._pokemonArray;
            set
            {
#pragma warning disable CS8622
                this._pokemonArray.CollectionChanged -= _pokemonArray_CollectionChanged;

                this._pokemonArray = value;

                this._pokemonArray.CollectionChanged -= _pokemonArray_CollectionChanged;
                this._pokemonArray.CollectionChanged += _pokemonArray_CollectionChanged;

            }
        }

        private void _pokemonArray_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.Invalidate();
        }

        public bool ContainsMouse => _containsMouse;

        public Point RelativeMousePosition => _relativeMousePosition;


        protected override void OnMouseEnter(EventArgs e)
        {
            this._containsMouse = false;
            this.Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this._containsMouse = true;
            this.Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            this._relativeMousePosition = new Point(e.X, e.Y);
            this.Invalidate();
            base.OnMouseMove(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);

            for (int i = 0; i < PokemonIDs.Count; i++)
            {
                var currPokeID = PokemonIDs[i];

                if (currPokeID == 0)
                {
                    continue;
                }

                if (Definitions.NationalDex.ContainsID(currPokeID))
                {
                    //Assembly.GetCallingAssembly().GetManifestResourceStream("WangPluginSav.")
                }
                else
                {

                }




            }



            base.OnPaint(e);
        }
    }
}
