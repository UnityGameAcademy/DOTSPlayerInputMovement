using Unity.Entities;
using System;
using UnityEngine;

public class PlayerInputSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref MoveData moveData, in InputData inputData) =>
        {
            bool isRightKeyPressed = Input.GetKey(inputData.rightKey);
            bool isLeftKeyPressed = Input.GetKey(inputData.leftKey);
            bool isUpKeyPressed = Input.GetKey(inputData.upKey);
            bool isDownKeyPressed = Input.GetKey(inputData.downKey);

            moveData.direction.x = Convert.ToInt32(isRightKeyPressed);
            moveData.direction.x -= Convert.ToInt32(isLeftKeyPressed);
            moveData.direction.z = Convert.ToInt32(isUpKeyPressed);
            moveData.direction.z -= Convert.ToInt32(isDownKeyPressed);

        }).Run();



    }
}
