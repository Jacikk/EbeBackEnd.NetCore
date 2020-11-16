import React from 'react'
import './styles.css'

export default function Button(props) {
    return (
        <a href={props.link} className='btn'><div>{props.btnName}</div></a>
    )
}