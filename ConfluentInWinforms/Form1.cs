using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfluentInWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            librdkafkaVersion.Text = "librdkafka version " + Library.VersionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var config = new Dictionary<string, object> { { "bootstrap.servers", textBox1.Text } };
            using (var producer = new Producer(config))
            {
                var meta = producer.GetMetadata(true, null);
                meta.Topics.ForEach(topic =>
                {
                    listView1.Items.Add(topic.Topic + " (" + topic.Partitions.Count + " partitions)");
                });
            }
        }
    }
}
