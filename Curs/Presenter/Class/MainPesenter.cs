using Curs.Model.Class;
using Curs.View.Class;
using Curs.View.Interface;
using Newtonsoft.Json;
using Curs.Presenter;
namespace Curs.Presenter.Class
{
    public class MainPesenter
    {
        public IMainView _mainView { get; set; }
        public List<AbstractPanelButton> buttons { get; set; } = new List<AbstractPanelButton> { };
        public JsonSave sl { get; set; } = new JsonSave();
        public MainPesenter(IMainView mainView)
        {
            _mainView = mainView;
            Load("Json\\save.json");
            InitializeComponent();
            
        }
        public void InitializeComponent()
        {
            _mainView.InputControls = new InterfaceButton(new Point(10, 10), "Assets\\circle.png", Create);
            _mainView.InputControls = new InterfaceButton(new Point(10, 70), "Assets\\arrow-left.png", Create);
            _mainView.InputControls = new InterfaceButton(new Point(10, 130), "Assets\\arrow-rigth.png", Create);
            _mainView.InputControls = new InterfaceButton(new Point(10, 190), "Assets\\arrow-up.png", Create);
            _mainView.InputControls = new InterfaceButton(new Point(10, 250), "Assets\\arrow-down.png", Create);
            _mainView.InputControls = new InterfaceButton(new Point(10, 310), "Assets\\arrow-circle-rigth.png", Create);
            _mainView.InputControls = new InterfaceButton(new Point(10, 370), "Assets\\arrow-circle-up.png", Create);
            _mainView.InputControls = new InterfaceButton(new Point(10, 430), "Assets\\arrow-circle-left.png", Create);
            _mainView.InputControls = new InterfaceButton(new Point(10, 490), "Assets\\arrow-circle-down.png", Create);
            _mainView.InputControls = new InterfaceButton(new Point(10, 550), "Assets\\text.png", Create);
            _mainView.InputControls = new InterfaceButton(new Point(10, 550), "Assets\\save.png", Create);
            _mainView.InputControls = new InterfaceButton(new Point(10, 610), "Assets\\computer.png", FMSShow);
            _mainView.InputControls = new InterfaceButton(new Point(10, 670), "Assets\\trash.png", ClearPanel);
            _mainView.InputControls = new InterfaceButton(new Point(10, 730), "Assets\\save.png", SavePanel);
        }
        private void Create(object sender, EventArgs e)
        {
            MouseEventHandler delete = DeleteButton;
            InterfaceButton butt = sender as InterfaceButton;
            AbstractPanelButton button = Distribution.DistributionButton(butt._fromFile);
            button.delete = delete;
            ref AbstractPanelButton n = ref button;
            buttons.Add(n);
            _mainView.InputPanel = button;
        }
        private void ClearPanel(object sender, EventArgs e)=>_mainView.ClearPanel();
        private void SavePanel(object sender, EventArgs e)=>sl.Save(buttons, "Json\\save.json");

        private void FMSShow(object sender, EventArgs e)
        {
            FSMPresenter fsmPresenter = new FSMPresenter(new FMSWindow());
            fsmPresenter.ShowWindow();
        }
        private void DeleteButton(object sender, MouseEventArgs e)
        {
            AbstractPanelButton butt = sender as AbstractPanelButton;
            if (e.Button == MouseButtons.Right)
                _mainView.RemovePanel = butt;
            
        }
        public void Load(string filepath)
        {
            MouseEventHandler delete = DeleteButton;
            StreamReader reader = new StreamReader(filepath);
            string json = reader.ReadToEnd();
            reader.Dispose();
            JsonSave tmp = JsonConvert.DeserializeObject<JsonSave>(json);
            for (int i = 0; i < tmp._buttImage.Count; i++)
            {
                AbstractPanelButton button = Distribution.DistributionButton(tmp._buttImage[i]);
                button.Size = tmp._buttSize[i];
                button.Location = tmp._buttLocation[i];
                button.delete = delete;
                _mainView.InputPanel = button;
            }
        }
    }
}
