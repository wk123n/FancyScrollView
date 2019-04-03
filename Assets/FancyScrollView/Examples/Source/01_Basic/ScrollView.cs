﻿using UnityEngine;
using System.Collections.Generic;

namespace FancyScrollView.Example01
{
    public class ScrollView : FancyScrollView<ItemData>
    {
        [SerializeField] Scroller scroller;
        [SerializeField] GameObject cellPrefab;

        protected override GameObject CellPrefab => cellPrefab;

        void Start()
        {
            scroller.OnValueChanged(UpdatePosition);
        }

        public void UpdateData(IList<ItemData> items)
        {
            UpdateContents(items);
            scroller.SetTotalCount(items.Count);
        }
    }
}