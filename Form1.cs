using ChromaSDK;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CSharp_ChromaStreamApp
{
    public partial class Form1 : Form
    {
        ChromaSDK.Stream.StreamStatusType _mStatus = ChromaSDK.Stream.StreamStatusType.SERVICE_OFFLINE;
        DateTime _mTimerRequest = DateTime.MinValue;

        string _mShortcode = ChromaSDK.Stream.Default.Shortcode;
        byte _mLenShortcode = 0;

        string _mStreamId = ChromaSDK.Stream.Default.StreamId;
        byte _mLenStreamId = 0;

        string _mStreamKey = ChromaSDK.Stream.Default.StreamKey;
        byte _mLenStreamKey = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool supportsStreaming = ChromaAnimationAPI.CoreStreamSupportsStreaming();
            if (!supportsStreaming)
            {
                _mPanelNotSupported.Visible = true;
                _mPanelBroadcast.Visible = false;
                return;
            }

            _mPanelNotSupported.Visible = false;
            _mPanelBroadcast.Visible = true;

            _mTimerForm.Tick += _mTimerForm_Tick;
            _mTimerForm.Start();
        }

        private void _mBtnGetStreamCode_Click(object sender, EventArgs e)
        {
            _mShortcode = ChromaSDK.Stream.Default.Shortcode;
            _mLenShortcode = 0;
            string strPlatform = "PC";
            ChromaAnimationAPI.CoreStreamGetAuthShortcode(ref _mShortcode, out _mLenShortcode, strPlatform, "C# Chroma Stream App");

            if (_mLenShortcode > 0)
            {
                _mTxtShortcode.Text = _mShortcode;
                _mTimerRequest = DateTime.Now + TimeSpan.FromMinutes(5);
            }
            else
            {
                _mTxtShortcode.Text = string.Empty;
            }
        }

        private void _mBtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(_mShortcode);
        }

        private void _mLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://stream.razer.com/");
            Process.Start(sInfo);
        }

        private void SetupBtnGetShortcode()
        {
            Action action = () =>
            {
                if (_mStatus != ChromaSDK.Stream.StreamStatusType.READY)
                {
                    _mBtnGetShortcode.Enabled = false;
                }
                else
                {
                    _mBtnGetShortcode.Enabled = true;
                }
            };

            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    action.Invoke();
                });
                return;
            }

            action.Invoke();
        }

        private void SetupBtnCopy()
        {
            Action action = () =>
            {
                if (_mTxtShortcode.Text.Length == 0)
                {
                    _mBtnCopy.Enabled = false;
                }
                else
                {
                    _mBtnCopy.Enabled = true;
                }
            };

            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    action.Invoke();
                });
                return;
            }

            action.Invoke();
        }

        private void SetupBroadcastCheckbox()
        {
            Action action = () =>
            {
                if (_mStatus == ChromaSDK.Stream.StreamStatusType.BROADCASTING)
                {
                    _mChkBroadcast.Checked = true;
                }

                if (_mStatus == ChromaSDK.Stream.StreamStatusType.BROADCASTING ||
                    (_mTxtStreamId.Text.Length > 0 && _mTxtStreamKey.Text.Length > 0))
                {
                    _mChkBroadcast.Enabled = true;
                }
                else
                {
                    _mChkBroadcast.Enabled = false;
                }
            };

            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    action.Invoke();
                });
                return;
            }

            action.Invoke();
        }

        private void _mTxtStreamId_TextChanged(object sender, EventArgs e)
        {
            _mTimerRequest = DateTime.MinValue;
        }

        private void _mTxtStreamKey_TextChanged(object sender, EventArgs e)
        {
            _mTimerRequest = DateTime.MinValue;
        }

        private void _mLinkSynapse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.razer.com/synapse-3");
            Process.Start(sInfo);
        }

        private void SetStatus(string status)
        {
            Action action = () =>
            {
                _mTxtStatus.Text = string.Format("Status: {0}", status);
            };

            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    action.Invoke();
                });
                return;
            }

            action.Invoke();
        }

        private void _mTimerForm_Tick(object sender, EventArgs e)
        {
            _mStatus = ChromaAnimationAPI.CoreStreamGetStatus();

            SetStatus(ChromaAnimationAPI.CoreStreamGetStatusString(_mStatus));

            SetupBtnGetShortcode();

            SetupBtnCopy();

            SetupBroadcastCheckbox();

            if (_mTimerRequest > DateTime.Now)
            {
                _mStreamId = ChromaSDK.Stream.Default.StreamId;
                _mLenStreamId = 0;
                ChromaAnimationAPI.CoreStreamGetId(_mShortcode, ref _mStreamId, out _mLenStreamId);
                if (_mLenStreamId > 0)
                {
                    _mStreamId = _mStreamId.Substring(0, _mLenStreamId);
                }

                _mStreamKey = ChromaSDK.Stream.Default.StreamKey;
                _mLenStreamKey = 0;
                ChromaAnimationAPI.CoreStreamGetKey(_mShortcode, ref _mStreamKey, out _mLenStreamKey);
                if (_mLenStreamId > 0)
                {
                    _mStreamKey = _mStreamKey.Substring(0, _mLenStreamKey);
                }

                if (_mLenStreamId > 0 && _mLenStreamId > 0)
                {
                    if (ChromaAnimationAPI.CoreStreamReleaseShortcode(_mShortcode))
                    {
                        _mShortcode = ChromaSDK.Stream.Default.Shortcode;
                        _mLenShortcode = 0;

                        _mTimerRequest = DateTime.MinValue;

                        Action action = () =>
                        {
                            _mTxtShortcode.Text = string.Empty;
                            _mTxtStreamId.Text = _mStreamId;
                            _mTxtStreamKey.Text = _mStreamKey;
                        };

                        if (this.InvokeRequired)
                        {
                            this.BeginInvoke((MethodInvoker)delegate
                            {
                                action.Invoke();
                            });
                            return;
                        }
                        action.Invoke();
                    }
                }
            }
        }

        private void _mChkBroadcast_CheckedChanged(object sender, EventArgs e)
        {
            if (_mChkBroadcast.Checked)
            {
                if (_mLenStreamId > 0 && _mLenStreamKey > 0)
                {
                    ChromaAnimationAPI.CoreStreamBroadcast(_mStreamId, _mStreamKey);
                }
            }
            else
            {
                ChromaAnimationAPI.CoreStreamBroadcastEnd();
            }
        }
    }
}
