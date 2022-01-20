import { Chip, createTheme } from '@material-ui/core';
import { withStyles } from '@material-ui/core/styles';
import classNames from 'classnames';
import * as React from 'react';
import altinnTheme from '../theme/altinnStudioTheme';

export interface IAltinnFilterChipComponentProvidedProps {
  classes: any;
  key: any;
  label: string;
  onclickFunction?: any;
  active: boolean;
  className?: string;
  deleteIcon?: any;
  onDeleteFunction?: any;
  sortIcon?: boolean;
}

export interface IAltinnFilterChipComponentState {
}

const theme = createTheme(altinnTheme);

const styles = {
  chip: {
    color: theme.altinnPalette.primary.black,
    borderColor: theme.altinnPalette.primary.blueDark,
    borderWidth: '1px',
    borderStyle: 'dotted',
    backgroundColor: theme.altinnPalette.primary.white,
    borderRadius: '36px',
    minHeight: '36px',
    fontSize: '16px',
    '&:hover': {
      backgroundColor: 'transparent !Important',
    },
    '&:focus': {
      backgroundColor: 'transparent !Important',
      borderColor: theme.altinnPalette.primary.blueDark,
      borderWidth: '1px',
      borderStyle: 'solid',
    },
  },
  chipActive: {
    backgroundColor: `${theme.altinnPalette.primary.blueLight} !Important`,
    border: `1px solid ${theme.altinnPalette.primary.blueDark}`,
    borderRadius: '36px',
    minHeight: '36px',
    fontSize: '16px',
    '&:hover': {
      backgroundColor: `${theme.altinnPalette.primary.blueLighter} !Important`,
    },
    '&:focus': {
      backgroundColor: `${theme.altinnPalette.primary.blueLighter} !Important`,
      border: `1px solid ${theme.altinnPalette.primary.blueDark}`,
      boxShadow: `0px 0px 6px ${theme.altinnPalette.primary.blueDark}`,
    },
  },
  down: {
    borderTop: `10px solid ${theme.altinnPalette.primary.black}`,
    borderLeft: '8px solid transparent',
    borderRight: '8px solid transparent',
    margin: '4px 8px 2px 0px',
  },
};

// eslint-disable-next-line max-len
const AltinnFilterChip = (props: IAltinnFilterChipComponentProvidedProps) => {
  const { classes } = props;
  return (
    <Chip
      key={props.key}
      label={props.label}
      clickable={true}
      color='primary'
      variant='outlined'
      onClick={props.onclickFunction}
      onDelete={props.onDeleteFunction}
      deleteIcon={props.sortIcon ? <i className={classNames(classes.down)} /> : props.deleteIcon}
      className={classNames(
        props.className,
        classes.chip,
        { [classes.chipActive]: props.active },
      )}
    />
  );
};

export default withStyles(styles)(AltinnFilterChip);
