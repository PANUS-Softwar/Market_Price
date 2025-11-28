using System.ComponentModel;
using System.Runtime.CompilerServices;
using TTEK_MAUI.Services;
using TTEK_MAUI.Models;

namespace TTEK_MAUI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly MarketDataService _dataService = new MarketDataService();

        private int _bidCount;
        private int _askCount;

        public MainViewModel()
        {
            _ = loadMarketDataAsync(); 
        }

        public int BidCount
        {
            get => _bidCount;
            set
            {
                if (_bidCount != value)
                {
                    _bidCount = value;
                    OnPropertyChanged();
                }
            }
        }

        public int AskCount
        {
            get => _askCount;
            set
            {
                if (_askCount != value)
                {
                    _askCount = value;
                    OnPropertyChanged(); 
                }
            }
        }

        private async Task loadMarketDataAsync()
        {
            BidCount = 0;
            AskCount = 0;

            var summary = await _dataService.GetMarketSummaryAsync();

            if (summary != null)
            {
                BidCount = summary.ActiveBidsCount;
                AskCount = summary.ActiveAsksCount;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged; 
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
