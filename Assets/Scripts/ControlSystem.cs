using UnityEngine;


namespace heyipomoea_twoD
{
    /// <summary>
    /// 2D橫向卷軸角色的控制系統:移動, 跳躍和動畫
    /// </summary>
    public class ControlSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(0, 500)]
        private float moveSpeed = 3.5f;
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3CheckGroundOffset = Vector3.zero;
        [SerializeField, Header("要偵測地板的圖層")]
        private LayerMask layerCheckGround;
        [SerializeField, Header("跳躍力道"), Range(0, 2000)]
        private float jumpPower = 1000;


        private Rigidbody2D rig;
        private Animator ani;
        private string parRun = "開關跑步";

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0, 0.3f, 0.5f);
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);
        }

        private void Awake()
        {
            //print("<color=yellow>喚醒事件</color>");
            rig = GetComponent<Rigidbody2D>();
            ani = GetComponent<Animator>();
        }
        private void Start()
        {
            //print("<color=green>開始事件</color>");
        }
        private void Update()
        {
            //print("<color=red>更新事件</color>");
            NewMethod();
            //CheckGround();
            Jump();
        }

        private void Jump()
        {
            if(CheckGround() && Input.GetKeyDown(KeyCode.Space))
            {
                rig.AddForce(new Vector2(0, jumpPower));
            }
        }
        /// <summary>
        /// 移動與翻面
        /// </summary>
        private void NewMethod()
        {
            //float v = Input.GetAxis("Vertical");
            //print("垂直的值 :" + v);

            float h = Input.GetAxis("Horizontal");
            rig.velocity = new Vector2(h * moveSpeed, rig.velocity.y);

            if (Input.GetKeyDown(KeyCode.A))
            {
                print("按下A");
                transform.eulerAngles = Vector3.zero;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                print("按下D");
                transform.eulerAngles = new Vector3(0, 180, 0);
            }

            ani.SetBool(parRun, h != 0);
        }
        
        private bool CheckGround()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0, layerCheckGround);
            //print($"碰到的物件:{hit.name}");
            return hit;
        }
    }
}

