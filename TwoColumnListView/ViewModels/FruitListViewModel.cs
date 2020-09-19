using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using TwoColumnListView.Models;
using Xamarin.Forms;

namespace TwoColumnListView.ViewModels
{
    public class FruitListViewModel
    {
        public List<FruitListGroup> Fruits { get; set; }
        public ICommand TapCommand { get; set; }
        public FruitListViewModel()
        { 
            TapCommand = new Command(Tap);
            Fruits = new List<FruitListGroup>();
            //C's
            Fruits.Add(new FruitListGroup("C", new List<FruitContainer>()
            {
                new FruitContainer()
                {
                    Fruit = new Fruit()
                    {
                        Name = "Cranberries",
                        Color = "Red"
                    },
                    Fruit1 = new Fruit()
                    {
                        Name = "Carambola",
                        Color = "Yellow"
                    }
                },
                new FruitContainer()
                {
                    Fruit = new Fruit()
                    {
                        Name = "Cherries",
                        Color = "Red"
                    },
                    Fruit1 = new Fruit()
                    {
                        Name = "",
                        Color = ""
                    }
                }
            }));
            //B's
            Fruits.Add(new FruitListGroup("B", new List<FruitContainer>()
            {
                new FruitContainer()
                {
                    Fruit = new Fruit()
                    {
                        Name = "Blood Oranges",
                        Color = "Red"
                    },
                    Fruit1 = new Fruit()
                    {
                        Name = "Banana",
                        Color = "Yellow"
                    }
                },
                new FruitContainer()
                {
                    Fruit = new Fruit()
                    {
                        Name = "",
                        Color = ""
                    },
                    Fruit1 = new Fruit()
                    {
                        Name = "",
                        Color = ""
                    }
                }
            }));

            //W's
            Fruits.Add(new FruitListGroup("W", new List<FruitContainer>()
            {
                new FruitContainer()
                {
                    Fruit = new Fruit()
                    {
                        Name = "Watermelon",
                        Color = ""
                    },
                    Fruit1 = new Fruit()
                    {
                        Name = "",
                        Color = ""
                    }
                },
                new FruitContainer()
                {
                    Fruit = new Fruit()
                    {
                        Name = "",
                        Color = ""
                    },
                    Fruit1 = new Fruit()
                    {
                        Name = "",
                        Color = ""
                    }
                }
            }));
            //P's
            Fruits.Add(new FruitListGroup("P", new List<FruitContainer>()
            {
                new FruitContainer()
                {
                    Fruit = new Fruit()
                    {
                        Name = "Pomegranates",
                        Color = "Red"
                    },
                    Fruit1 = new Fruit()
                    {
                        Name = "Pineapple",
                        Color = "Yellow"
                    }
                },
                new FruitContainer()
                {
                    Fruit = new Fruit()
                    {
                        Name = "Pears",
                        Color = ""
                    },
                    Fruit1 = new Fruit()
                    {
                        Name = "",
                        Color = ""
                    }
                }
            }));
            //R's
            Fruits.Add(new FruitListGroup("R", new List<FruitContainer>()
            {
                new FruitContainer()
                {
                    Fruit = new Fruit()
                    {
                        Name = "Red Apples",
                        Color = "Red"
                    },
                    Fruit1 = new Fruit()
                    {
                        Name = "",
                        Color = ""
                    }
                },
                new FruitContainer()
                {
                    Fruit = new Fruit()
                    {
                        Name = "Red Grapes",
                        Color = "Red",
                        Image ="redgrapes.jpg"
                    },
                    Fruit1 = new Fruit()
                    {
                        Name = "",
                        Color = ""
                    }
                },
                new FruitContainer()
                {
                    Fruit = new Fruit()
                    {
                        Name = "Red Grapefruit",
                        Color = "Red"
                    },
                    Fruit1 = new Fruit()
                    {
                        Name = "",
                        Color = ""
                    }
                }
            }));
        }

        private void Tap()
        {
            var x = new Fruit();
            Debug.Write("Tap on Fruit 2 recognized");
        }
    }
}
