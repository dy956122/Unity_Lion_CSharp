using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    [Header("怪物陣列 0 狐狸 1 老鷹 2 老鼠 3 青蛙")]
    public GameObject[] monster;

    /// <summary>
    /// 生成怪物
    /// </summary>
    /// <param name="index"></param>
    public void CreateMonster(int index)
    {
        Instantiate(monster[index], new Vector3(-10, 0, 0), Quaternion.identity);
    }
}
