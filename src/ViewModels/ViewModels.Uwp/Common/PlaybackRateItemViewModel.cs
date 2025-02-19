﻿// Copyright (c) Richasy. All rights reserved.

using System;
using System.Reactive;
using Bili.ViewModels.Interfaces.Common;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Bili.ViewModels.Uwp.Common
{
    /// <summary>
    /// 播放速率条目视图模型.
    /// </summary>
    public sealed class PlaybackRateItemViewModel : SelectableViewModelBase<double>, IPlaybackRateItemViewModel
    {
        private Action<double> _action;

        /// <inheritdoc/>
        [Reactive]
        public ReactiveCommand<Unit, Unit> ActiveCommand { get; set; }

        /// <inheritdoc/>
        public void InjectAction(Action<double> action)
        {
            _action = action;
            ActiveCommand = ReactiveCommand.Create(() => { _action.Invoke(Data); });
        }
    }
}
