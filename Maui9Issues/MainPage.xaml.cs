using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;

namespace Maui9Issues
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            AddBehaviors(this);
        }

        void AddBehaviors(Page page)
        {
            Behaviors.Add(
                new StatusBarBehavior
                {
                    StatusBarColor = Colors.Green,
                    StatusBarStyle = StatusBarStyle.LightContent,
                    ApplyOn = StatusBarApplyOn.OnBehaviorAttachedTo
                }
            );

            Behaviors.Add(
                new StatusBarBehavior
                {
                    StatusBarColor = Colors.Blue,
                    StatusBarStyle = StatusBarStyle.LightContent,
                    ApplyOn = StatusBarApplyOn.OnPageNavigatedTo
                }
            );

            Behaviors.Add(
                new StatusBarBehavior
                {
                    StatusBarColor = Colors.Red,
                    StatusBarStyle = StatusBarStyle.DarkContent,
                    ApplyOn = StatusBarApplyOn.OnBehaviorAttachedTo
                }
            );

            Behaviors.Add(
                new StatusBarBehavior
                {
                    StatusBarColor = Colors.Magenta,
                    StatusBarStyle = StatusBarStyle.DarkContent,
                    ApplyOn = StatusBarApplyOn.OnPageNavigatedTo
                }
            );
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var b = new Button() { Text = "Click" };
            b.Clicked += (s, a) =>
            {
                var page = new ContentPage() { Content = new Label() { Text = "Text" } };
                //AddBehaviors(page);

                Navigation.PushModalAsync(page);
            };

            var page = new ContentPage() { Content = b };
            //AddBehaviors(page);

            Navigation.PushModalAsync(page);
        }
    }

}
