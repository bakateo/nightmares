using System.Collections.Generic;
using UnityEngine;
namespace HSRM.Scripts.mabentiv.Commands
{
    public class CompoundSelectionCommand : BaseCommand
    {
        [SerializeField] private bool stopOnFirstSelection = true;
        [SerializeField] private List<BaseSelectionCommand> selectionCommands = new List<BaseSelectionCommand>();

        protected override void ExecuteCommand()
        {
            foreach (var selectionCommand in selectionCommands)
            {
                selectionCommand.Execute();
                if (selectionCommand.HasSelection && stopOnFirstSelection)
                { 
                    return;
                }
            }
        }
    }

}