using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HSRM.Scripts.mabentiv.Commands
{

    public abstract class BaseUndoableCommand : BaseCommand
    {
        public abstract bool CanUndo { get; }

        protected abstract void UndoCommand();

        public void Undo()
        {
            if (CanUndo)
            {
                UndoCommand();
            }
        }

        public void UndoDelayed(float delay)
        {
            StartCoroutine(DelayedUndo(delay));
        }
        private IEnumerator DelayedUndo(float delay)
        {
            yield return new WaitForSeconds(delay);
            Undo();
        }

    }
}