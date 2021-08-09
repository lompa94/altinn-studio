/* eslint-disable no-nested-ternary */
/* eslint-disable max-len */
import * as React from 'react';
import { AltinnButton } from 'altinn-shared/components';
import { Grid, makeStyles } from '@material-ui/core';
import { useDispatch, useSelector } from 'react-redux';
import { IRuntimeState, INavigationConfig, ILayoutNavigation, Triggers } from 'src/types';
import classNames from 'classnames';
import { getTextFromAppOrDefault } from 'src/utils/textResource';
import { FormLayoutActions } from 'src/features/form/layout/formLayoutSlice';

const useStyles = makeStyles({
    ul: {
        backgroundColor: '#59f4fb',
        border: '2px solid'
    },
});

export interface INavComponent {
  id: string;
  showBackButton: boolean;
  textResourceBindings: any;
  triggers?: Triggers[];
}

export function NavComponent(props: INavComponent) {
  const classes = useStyles();
  const dispatch = useDispatch();
  const [disableBack, setDisableBack] = React.useState<boolean>(false);
  const [disableNext, setDisableNext] = React.useState<boolean>(false);
  const currentView = useSelector((state: IRuntimeState) => state.formLayout.uiConfig.currentView);
  const orderedLayoutKeys = useSelector((state: IRuntimeState) => state.formLayout.uiConfig.layoutOrder);
  const returnToView = useSelector((state: IRuntimeState) => state.formLayout.uiConfig.returnToView);
  const textResources = useSelector((state: IRuntimeState) => state.textResources.resources);
  const language = useSelector((state: IRuntimeState) => state.language.language);
  const pageTriggers = useSelector((state: IRuntimeState) => state.formLayout.uiConfig.pageTriggers);
  const { next, previous } = useSelector(
    (state: IRuntimeState) => getNavigationConfigForCurrentView(
      state.formLayout.uiConfig.navigationConfig,
      state.formLayout.uiConfig.currentView,
    ),
  );
  const triggers = props.triggers || pageTriggers;

  const OnClickNav = (index: string) => {
    const runPageValidations = !returnToView && triggers?.includes(Triggers.ValidatePage);
    const runAllValidations = returnToView || triggers?.includes(Triggers.ValidateAllPages);
    const runValidations = (runAllValidations && 'allPages') || (runPageValidations && 'page') || null;
    dispatch(FormLayoutActions.updateCurrentView({ newView: index, runValidations }));
  };

  const sideListe = orderedLayoutKeys.map((x) => 
    <li><a href="#" onClick={() => OnClickNav(x)}>{x}</a></li>
  );

  return (
    <Grid
      container={true}
      justify='space-between'
    >
      <Grid item={true} xs={10}>
        <ul>{sideListe}</ul>
      </Grid>
    </Grid>
  );
}

function getNavigationConfigForCurrentView(
  navigationConfig: INavigationConfig,
  currentView: string,
): ILayoutNavigation {
  if (navigationConfig && navigationConfig[currentView]) {
    return navigationConfig[currentView];
  }
  return {};
}
