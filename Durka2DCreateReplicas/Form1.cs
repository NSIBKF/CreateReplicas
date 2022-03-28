using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Durka2DCreateReplicas
{
    public partial class Durka2DCreateReplicas : Form
    {
        public Durka2DCreateReplicas()
        {
            InitializeComponent();
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            Replica replica = new Replica(textBox1.Text, CharacterNameTextBox.Text);

            Add(replica);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Replica replica = (Replica)listView1.SelectedItems[0].Tag;
                if (replica != null)
                {
                    listView1.Text = replica.replica;
                }
            }

        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            Replicas replicas = new Replicas();
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Tag != null)
                {
                    replicas.ReplicasList.Add((Replica)item.Tag);
                }
            }
            SerializeXML(replicas);
        }
        private void DeserializeButton_Click(object sender, EventArgs e)
        {

            Replicas replicas = DesirealizeXML();
            foreach(Replica replica in replicas.ReplicasList)
            {
                Add(replica);
            }
        }
        private void SerializeXML(Replicas replicas)
        {

            XmlSerializer xml = new XmlSerializer(typeof(Replicas));

            using (FileStream fs = new FileStream("Replicas.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, replicas);
            }
        }

        private Replicas DesirealizeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Replicas));

            using (FileStream fs = new FileStream("Replicas.xml", FileMode.OpenOrCreate))
            {
                return (Replicas)xml.Deserialize(fs);
            }
        }

        private void Add(Replica replica)
        {
            ListViewItem LVI = new ListViewItem(replica.replica);
            LVI.Tag = replica;

            listView1.Items.Add(LVI);
        }


        private void CharacterNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
